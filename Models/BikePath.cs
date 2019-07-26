using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BikeGallery.Models
{
    public class BikePath
    {
        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHtml { get; set; }
        public Rider[] Riders { get; set; }
        public bool Favorite { get; set; }
    }
}