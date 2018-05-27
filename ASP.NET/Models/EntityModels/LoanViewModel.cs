using ServiceReference;
using System.Collections.Generic;


namespace Library.Web.Models.EntityModels
{
    public class LoanViewModel
    {
        public LoanViewModel()
        {
            REVIEWs = new List<REVIEW>();
            CARTEs = new List<CARTE>();
        }

        public IMPRUMUT IMPRUMUT { get; set; }
        public List<IMPRUMUT> IMPRUMUTs { get; set; }

        public CARTE CARTE { get; set; }
        public CITITOR CITITOR { get; set; }

        public ICollection<CARTE> CARTEs { get; set; }
        public ICollection<REVIEW> REVIEWs { get; set; }

        public string ActionLink { get; set; }
        public string RedirectLink { get; set; }
    }
}
