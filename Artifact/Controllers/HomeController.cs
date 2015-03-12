using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccess;
using System.Data.Entity;

namespace Artifact.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using(var ctx = new ArtifactContext())
            {
                ctx.Steps.Where(el => el.StepId == 1);
            }

            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
