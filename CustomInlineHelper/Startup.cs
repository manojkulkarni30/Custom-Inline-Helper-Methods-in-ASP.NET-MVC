using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomInlineHelper.Startup))]
namespace CustomInlineHelper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
