using ServiceReference;
using System.Collections.Generic;


namespace Library.Web.Models.EntityModels
{
    public class ReaderViewModel
    {
        public ReaderViewModel()
        {
            IMPRUMUTs = new List<IMPRUMUT>();
        }

        public CITITOR CITITOR { get; set; }
        public List<CITITOR> CITITORs { get; set; }
        public ICollection<IMPRUMUT> IMPRUMUTs { get; set; }

        public string ActionLink { get; set; }
        public string RedirectLink { get; set; }
    }
}
