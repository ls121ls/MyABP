using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MyABP.Entities;

namespace MyABP.Web.Controllers
{
    public class HomeController : MyABPControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }

        public ActionResult Test()
        {
            return View();
        }

        public ActionResult T()
        {
            return View();
        }

        [HttpPost]
        public void T(FormCollection Collection)
        {

            var t=RouteData.DataTokens["Controller"];
            Response.Redirect(HttpContext.Request.UrlReferrer.ToString());
            List<USERS> users = new List<USERS>();
            users.Where()
        }
    }
}