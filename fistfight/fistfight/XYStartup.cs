using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(fistfight.XYStartup))]

namespace fistfight
{
    public class XYStartup
    {
        public void Configuration(IAppBuilder app)
        {
            // 有关如何配置应用程序的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkID=316888
            app.MapSignalR<XYConnection>("/myPath"); // myPath 是我们随便写的。
        }
    }
}
