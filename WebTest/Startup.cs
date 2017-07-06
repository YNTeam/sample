using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebTest.Startup))]
namespace WebTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            //在这边也加一个注释吧！modify by landy
            //这里的注释要删除！ modify by pengyou
            //应该要再添加点注释猜对！！！！
        }
    }
}
