namespace Library.Data.Entities
{
    using System.Collections.Generic;

    public class GEN
    {
        public GEN()
        {
            CARTEs = new List<CARTE>();
        }

        public int GenId { get; set; }
        public string Descriere { get; set; }

        public ICollection<CARTE> CARTEs { get; set; }
    }
}
