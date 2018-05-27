using ServiceReference;
using System;
using System.Collections.Generic;

namespace Library.Web.Models.EntityModels
{
    public class StatisticsViewModel
    {
        public string[] ArrayGen { get; set; }
        public string[] ArrayReader { get; set; }
        public string[] ArrayAuthor { get; set; }
        public string[] ArrayBook { get; set; }
        public string[] ArrayReview { get; set; }


        public DateTime StartDate { get; set; }
        public DateTime StopDate { get; set; }
        public string TitluCarte { get; set; }

        public string NumeGen { get; set; }
        public string NumeAutor { get; set; }
        public string NumeCarte { get; set; }
    }
}
