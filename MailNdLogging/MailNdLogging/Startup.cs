using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System.Web.Mvc;
using System.Web.Routing;

[assembly: OwinStartup(typeof(MailNdLogging.Startup))]

namespace MailNdLogging
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            AreaRegistration.RegisterAllAreas();
            // RouteConfig.RegisterRoutes(RouteTable.Routes);

            var option = new CookieAuthenticationOptions()
            {
                AuthenticationType = "ApplicationCookie",
                CookieName = "Logging",
                LoginPath = new PathString("/LoginAuth/Login")
            };
            

            app.UseCookieAuthentication(option);
        }
    }
}
