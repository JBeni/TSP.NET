namespace Library.Data.Entities
{
    using System.Collections.Generic;

    public class AUTOR
    {
        public AUTOR()
        {
            CARTEs = new List<CARTE>();
        }

        public int AutorId { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }

        public ICollection<CARTE> CARTEs { get; set; }
    }
}
