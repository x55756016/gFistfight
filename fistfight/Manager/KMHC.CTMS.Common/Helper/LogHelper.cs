using SMT.Foundation.Log;
using System;
using System.Collections.Generic;
using System.IO;

namespace Project.Common.Helper
{
    public class LogHelper
    {
        //static Logger log = new Logger("KMLOG");
        /// <summary>
        /// 记录错误信息
        /// </summary>
        /// <param name="msg"></param>
        public static void WriteError(string msg)
        {
            Tracer.Debug(msg);
        }
        /// <summary>
        /// 记录Debug信息
        /// </summary>
        /// <param name="msg"></param>
        public static void WriteDebug(string msg)
        {
            Tracer.Debug(msg);
        }
        /// <summary>
        /// 记录警告信息
        /// </summary>
        /// <param name="msg"></param>
        public static void WriteWarn(string msg)
        {
            Tracer.Debug(msg);
        }
        /// <summary>
        /// 记录普通信息
        /// </summary>
        /// <param name="msg"></param>
        public static void WriteInfo(string msg)
        {
            Tracer.Debug(msg);
        }
        /// <summary>
        /// 记录严重错误信息
        /// </summary>
        /// <param name="msg"></param>
        public static void WriteFatal(string msg)
        {
            Tracer.Debug(msg);
        }
    }
}