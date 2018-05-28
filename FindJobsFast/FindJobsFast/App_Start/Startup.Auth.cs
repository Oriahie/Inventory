using FindJobsFast.Models;
using FindJobsFast.Providers;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System;

namespace FindJobsFast
{
    public partial class Startup
    {
        public static Func<UserManager<ApplicationUser, string>> UserManagerFactory { get; private set; } = Create;
        public static Func<RoleManager<AppRole, string>> RoleManagerFactory { get; private set; } = RoleCreate;


        public static UserManager<ApplicationUser, string> Create()
        {
            var dbContext = new ApplicationDbContext();
            var store = new UserStore<ApplicationUser, AppRole, string, AppUserLogin, AppUserRole, AppUserClaim>(dbContext);
            var usermanager = new UserManager<ApplicationUser, string>(store);
            //>>>>>>> 119ce060192f8ea4abc63bde2643ff4151f331a8
            // allow alphanumeric characters in username
            usermanager.UserValidator = new UserValidator<ApplicationUser, string>(usermanager)
            {
                AllowOnlyAlphanumericUserNames = false,
                RequireUniqueEmail = false,
            };

            usermanager.PasswordValidator = new PasswordValidator()
            {
                RequiredLength = 4,
                RequireDigit = false,
                RequireUppercase = false
            };

            return usermanager;
        }
        public static RoleManager<AppRole, string> RoleCreate()
        {
            var dbContext = new ApplicationDbContext();
            var store = new RoleStore<AppRole, string, AppUserRole>(dbContext);
            var rolemanager = new RoleManager<AppRole, string>(store);

            return rolemanager;
        }







        public static OAuthAuthorizationServerOptions OAuthOptions { get; private set; }

        public static string PublicClientId { get; private set; }

        // For more information on configuring authentication, please visit https://go.microsoft.com/fwlink/?LinkId=301864
        public void ConfigureAuth(IAppBuilder app)
        {
            // Configure the db context and user manager to use a single instance per request
            app.CreatePerOwinContext(ApplicationDbContext.Create);
            app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);

            // Enable the application to use a cookie to store information for the signed in user
            // and to use a cookie to temporarily store information about a user logging in with a third party login provider
            app.UseCookieAuthentication(new CookieAuthenticationOptions());
            app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);

            // Configure the application for OAuth based flow
            PublicClientId = "self";
            OAuthOptions = new OAuthAuthorizationServerOptions
            {
                TokenEndpointPath = new PathString("/Token"),
                Provider = new ApplicationOAuthProvider(PublicClientId),
                AuthorizeEndpointPath = new PathString("/api/Account/ExternalLogin"),
                AccessTokenExpireTimeSpan = TimeSpan.FromMinutes(20),
                // In production mode set AllowInsecureHttp = false
                AllowInsecureHttp = true
            };

            // Enable the application to use bearer tokens to authenticate users
            app.UseOAuthBearerTokens(OAuthOptions);

            // Uncomment the following lines to enable logging in with third party login providers
            //app.UseMicrosoftAccountAuthentication(
            //    clientId: "",
            //    clientSecret: "");

            //app.UseTwitterAuthentication(
            //    consumerKey: "",
            //    consumerSecret: "");

            //app.UseFacebookAuthentication(
            //    appId: "",
            //    appSecret: "");

            //app.UseGoogleAuthentication(new GoogleOAuth2AuthenticationOptions()
            //{
            //    ClientId = "",
            //    ClientSecret = ""
            //});
        }
    }
}
