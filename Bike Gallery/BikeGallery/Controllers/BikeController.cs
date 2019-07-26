using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BikeGallery.Controllers
{
    public class BikeController : Controller
    {
        public ActionResult Detail()
        {
            ViewBag.SeriesTitle = "Fort Stevens";
            ViewBag.IssueNumber = "1";
            ViewBag.Description = "<p> a description of the ride at Fort Stevens.</p>";
            ViewBag.Riders = new string[]
                {
                "Mom: Cheryl",
                "Dad:  Jason",
                "Child 1:  Ash",
                "Child 2: Sage"
                };

            return View();
        }
    }  

}