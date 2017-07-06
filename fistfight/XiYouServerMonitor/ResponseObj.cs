using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XiYouServerMonitor
{
    public class ResponseObj<T>
    {
        /// <summary>
        /// 返回的数据类型，msginfo聊天信息，batinfo战斗信息
        /// </summary>
        public string DataType { get; set; }


        /// <summary>
        /// 返回的对象类型obj，list
        /// </summary>
        public string ObjType { get; set; }
        /// <summary>
        /// 是否成功 0失败，1成功
        /// </summary>
        public string IsSuccess { get; set; }


        /// <summary>
        /// 返回的对象
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// 其他消息
        /// </summary>
        public string MessageInfo { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        public int PagesCount { get; set; }


        /// <summary>
        /// 对象总个数
        /// </summary>
        public int ObjCount { get; set; }

        /// <summary>
        /// 错误消息
        /// </summary>
        public string ErrMsg { get; set; }
    }
}
