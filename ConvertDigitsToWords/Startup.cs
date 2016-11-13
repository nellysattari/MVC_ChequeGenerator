using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConvertDigitsToWords.Startup))]
namespace ConvertDigitsToWords
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
