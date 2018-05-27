using ServiceReference;
using System.Collections.Generic;


namespace Library.Web.Models.EntityModels
{
    public class AuthorViewModel
    {
        public AuthorViewModel()
        {
            CARTEs = new List<CARTE>();
        }

        public AUTOR AUTOR { get; set; }
        public List<AUTOR> AUTORs { get; set; }

        public ICollection<CARTE> CARTEs { get; set; }
    }
}
