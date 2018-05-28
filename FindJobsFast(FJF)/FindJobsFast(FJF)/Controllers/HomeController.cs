using System.Web.Mvc;

namespace FindJobsFast_FJF_.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

      
    }
}
