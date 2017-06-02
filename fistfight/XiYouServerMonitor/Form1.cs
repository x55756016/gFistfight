using SuperWebSocket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XiYouServerMonitor
{
    public partial class Form1 : Form
    {
        private SimpleWebsocket simpleWebsocket;
        private BoardcastWebSocket boardcastWebsocket;
        private ChatWebSocket chatWebsocket;
        public Form1()
        {
            InitializeComponent();

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            simpleWebsocket = new SimpleWebsocket();
            boardcastWebsocket = new BoardcastWebSocket();
            chatWebsocket = new ChatWebSocket();

            simpleWebsocket.Start();
            boardcastWebsocket.Start();
            chatWebsocket.Start();
            labTxtMsg.Text = "服务器启动成功，在8080端口开启监听";
        
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                simpleWebsocket.Stop();
                boardcastWebsocket.Stop();
                chatWebsocket.Stop();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
