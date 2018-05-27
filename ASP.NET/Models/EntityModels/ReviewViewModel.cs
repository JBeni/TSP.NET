using ServiceReference;
using System.Collections.Generic;


namespace Library.Web.Models.EntityModels
{
    public class ReviewViewModel
    {
        public REVIEW REVIEW { get; set; }
        public List<REVIEW> REVIEWs { get; set; }

        public IMPRUMUT IMPRUMUT { get; set; }
        public CITITOR CITITOR { get; set; }
        public CARTE CARTE { get; set; }

        public string ActionLink { get; set; }
        public string RedirectLink { get; set; }
    }
}