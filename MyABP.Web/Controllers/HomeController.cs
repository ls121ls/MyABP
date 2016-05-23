using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using Abp.Dependency;
using MyABP.Dto;
using MyABP.Entities;
using MyABP.EntityFramework;
using MyABP.EntityFramework.Repositories;

namespace MyABP.Web.Controllers
{
    public class HomeController : MyABPControllerBase,ITransientDependency
    {
        private readonly IIocResolver _iocResolver;

        public HomeController(IIocResolver iocResolver)
        {
            _iocResolver = iocResolver;
        }


        public ActionResult Index()
        {
            ViewBag.Users=_iocResolver.Resolve<UsersService>().GetAllUser();
            return View();
            //return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }

        public ActionResult AddUsers()
        {
            for (int i = 0; i < 10; i++)
            {
                USERS users = new USERS();
                users.USER_NAME = "ls" + i;
                _iocResolver.Resolve<UsersService>().Create(users);
            }
            return Content("ok");
        }

        public ActionResult Test()
        {
            Response.Write(HttpContext.Request.ApplicationPath);
            return View();
        }

        public ActionResult T()
        {
            return View();
        }

        [HttpPost]
        public void T(FormCollection Collection)
        {
            
            
        }

        protected override void Initialize(RequestContext requestContext)
        {
            base.Initialize(requestContext);
        }
    }
}