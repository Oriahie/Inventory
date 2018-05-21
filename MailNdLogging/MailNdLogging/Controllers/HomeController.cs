using System.Web.Mvc;

namespace MailNdLogging.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Success()
        {
            return View();
        }
    }
}