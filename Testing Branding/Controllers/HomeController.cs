using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Testing_Branding.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var requestQry = Request.QueryString["BrandLegalName"];
            if(requestQry == null || requestQry.Length == 0)
            {
                requestQry = "Default Testing Legal Name";
            }
            ViewBag.BrandName = requestQry;

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