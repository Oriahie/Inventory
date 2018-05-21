using MailNdLogging.Models;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace MailNdLogging.Controllers
{

    public class LoginAuthController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(LoginInfo loginInfo)
        {
            
            var email = "admin@admin.com";
            var password = "admin";

            if (ModelState.IsValid && email==loginInfo.Email && password == loginInfo.Password)
            {
                
                ClaimsIdentity claimsIdentity = new ClaimsIdentity("ApplicationCookie");
                claimsIdentity.AddClaim(new Claim(ClaimTypes.Email, loginInfo.Email));
                var context = Request.GetOwinContext();
                context.Authentication.SignIn(claimsIdentity);

                return RedirectToAction("Index","Home");

            }
            else
                ModelState.AddModelError("", "Invalid Username or Password");


            return View(loginInfo);

        }

        public ActionResult Signout()
        {
            var context = Request.GetOwinContext();
            context.Authentication.SignOut("ApplicationCookie");
            return Redirect("Login");
        }


    }



}