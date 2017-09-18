using System;
using System.Threading;
using SuperWebSocket;
using Project.Model;
using Project.BLL;
using Newtonsoft.Json;
using System.Collections.Generic;
using SMT.Foundation.Log;

namespace XiYouServerMonitor
{
    /// <summary>
    /// 服务端向客户端进行广播
    /// </summary>
    public class BoardcastWebSocket
    {
        private const string ip = "127.0.0.1";
        private const int port = 2017;
        private WebSocketServer ws = null;//SuperWebSocket中的WebSocketServer对象
        private Timer timer = null;
        private FightHelper_User fighter;


        public BoardcastWebSocket()
        {
            ws = new WebSocketServer();//实例化WebSocketServer

            //添加事件侦听
            ws.NewSessionConnected += ws_NewSessionConnected;//有新会话握手并连接成功
            ws.SessionClosed += ws_SessionClosed;//有会话被关闭 可能是服务端关闭 也可能是客户端关闭
            ws.NewMessageReceived += ws_NewMessageReceived;
            fighter.FightComplete += fighter_FightComplete;
        }

        void fighter_FightComplete(object sender, V_xy_sp_userView e)
        {
            throw new NotImplementedException();
        }

        void ws_NewMessageReceived(WebSocketSession session, string value)
        {
            string SpiritJsonData = string.Empty;
            try
            {
                string tokenValue = session.Path.Split('=')[1];
                V_xy_sp_userView userView = CacheServer.GetUserViewFromCache(tokenValue);
                switch (value)
                {
                    case "skill1":
                        string batmsgAll = string.Empty;
                        fighter = new FightHelper_User();
                        //List<V_xy_sp_spirit> Enemys
                        V_xy_sp_userView userViewResult = fighter.UserStartFight(userView, "skill1", ref batmsgAll);
                       
                        //更新缓存的敌人信息
                        //userView.Task.SpiritsList.Clear();
                        //userView.Task.SpiritsList.AddRange(Enemys);
                        CacheServer.UpdatetUserViewCache(tokenValue, userView);

                        ResponseObj<V_xy_sp_userView> resBat = new ResponseObj<V_xy_sp_userView>()
                        {
                            DataType = "batinfo",
                            ObjType = "obj",
                            IsSuccess = "1",
                            Data = userViewResult,
                            MessageInfo = batmsgAll
                        };
                        SpiritJsonData = JsonConvert.SerializeObject(resBat);
                        break;
                    default:
                        V_xy_sp_userspirit spirit = userView.Spirit;
                        ResponseObj<string> resMsg = new ResponseObj<string>()
                            {
                                DataType = "msginfo",
                                ObjType = "obj",
                                IsSuccess = "1",
                                Data = spirit.SpiritName + " 说：" + value
                            };
                        SpiritJsonData = JsonConvert.SerializeObject(resMsg);
                        break;
                }
                SendToAll(session, SpiritJsonData);
            }catch(Exception ex)
            {
                Tracer.Debug(ex.ToString());
            }
        }

        void ws_NewSessionConnected(WebSocketSession session)
        {
            Console.WriteLine("{0:HH:MM:ss}  与客户端:{1}创建新会话", DateTime.Now, session.Cookies["token"]);
        }

        void ws_SessionClosed(WebSocketSession session, SuperSocket.SocketBase.CloseReason value)
        {
            Console.WriteLine("{0:HH:MM:ss}  与客户端:{1}的会话被关闭 原因：{2}", DateTime.Now, session.Cookies["token"], value);
        }


        /// <summary>
        /// 启动服务
        /// </summary>
        /// <returns></returns>
        public void Start()
        {
            if (!ws.Setup(ip, port))
            {
                Console.WriteLine("BoardCastWebSocket 设置WebSocket服务侦听地址失败");
                return;
            }

            if (!ws.Start())
            {
                Console.WriteLine("BoardCastWebSocket 启动WebSocket服务侦听失败");
                return;
            }

            Console.WriteLine("BoardCastWebSocket 启动服务成功");

            //timer = new Timer((data) =>
            //{
            //    var msg = string.Format("服务器当前时间：{0:HH:MM:ss}", DateTime.Now);

            //    //对当前已连接的所有会话进行广播
            //    foreach (var session in ws.GetAllSessions())
            //    {
            //        session.Send(msg);
            //    }

            //}, null, 1000, 1000);


         
        }
        private void SendToAll(WebSocketSession session, string msg)
        {
            //广播
            foreach (var sendSession in session.AppServer.GetAllSessions())
            {
                sendSession.Send(msg);
            }
        }

        /// <summary>
        /// 停止侦听服务
        /// </summary>
        public void Stop()
        {
            if (timer != null)
            {
                timer.Dispose();
            }
            if (ws != null)
            {
                ws.Stop();
            }
        }
    }
}
