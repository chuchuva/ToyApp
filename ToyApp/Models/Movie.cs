using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToyApp.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public string PlotOutline { get; set; }
    }
}
