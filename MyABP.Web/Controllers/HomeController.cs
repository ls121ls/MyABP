using System.Web.Mvc;

namespace MyABP.Web.Controllers
{
    public class HomeController : MyABPControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}