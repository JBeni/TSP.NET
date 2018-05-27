using ServiceReference;
using System.Collections.Generic;


namespace Library.Web.Models.EntityModels
{
    public class GenreViewModel
    {
        public GenreViewModel()
        {
            CARTEs = new List<CARTE>();
        }

        public GEN GEN { get; set; }
        public List<GEN> GENs { get; set; }

        public ICollection<CARTE> CARTEs { get; set; }

        public string ActionLink { get; set; }
        public string RedirectLink { get; set; }
    }
}