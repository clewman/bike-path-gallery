using BikeGallery.Models;
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
            var bikePath = new BikePath()
            {
                SeriesTitle = "Fort Stevens",
                IssueNumber = 1,
                DescriptionHtml = "<p> a description of the ride at Fort Stevens.</p>",
                Riders = new Rider[]
                {
                    new Rider() { Name = "Sage", Role = "Rock Star"},
                    new Rider() { Name = "Ash", Role = "Rock Star"},
                    new Rider() { Name = "Jason", Role = "Papa"},
                    new Rider() { Name = "Cheryl", Role = "Mama"},

                }
            };

            return View(bikePath);
        }
    }  

}