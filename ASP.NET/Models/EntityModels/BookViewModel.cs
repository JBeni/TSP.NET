using ServiceReference;
using System.Collections.Generic;


namespace Library.Web.Models.EntityModels
{
    public class BookViewModel
    {
        public BookViewModel()
        {
            IMPRUMUTs = new List<IMPRUMUT>();
        }

        public int numarCarti { get; set; }

        public CARTE CARTE { get; set; }
        public List<CARTE> CARTEs { get; set; }

        public AUTOR AUTOR { get; set; }
        public List<AUTOR> AUTORs { get; set; }

        public GEN GEN { get; set; }
        public List<GEN> GENs { get; set; }

        public ICollection<IMPRUMUT> IMPRUMUTs { get; set; }

        public string ActionLink { get; set; }
        public string RedirectLink { get; set; }
    }
}
