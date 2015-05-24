using System.Web.Mvc;

namespace CustomInlineHelper.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Fruits = new string[] {"Apple", "Mango", "Lemon"};
            ViewBag.Flowers = new string[] { "Rose", "Jasmine", "Sunflower" };
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}