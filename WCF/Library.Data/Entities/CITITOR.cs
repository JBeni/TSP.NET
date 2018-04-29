namespace Library.Data.Entities
{
    using System.Collections.Generic;

    public class CITITOR
    {
        public CITITOR()
        {
            IMPRUMUTs = new List<IMPRUMUT>();
        }

        public int CititorId { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Adresa { get; set; }
        public string Email { get; set; }
        public int Stare { get; set; }

        public ICollection<IMPRUMUT> IMPRUMUTs { get; set; }
    }
}
