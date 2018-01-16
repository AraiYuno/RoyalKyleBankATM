using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BankATM.Startup))]
namespace BankATM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
