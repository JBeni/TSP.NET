namespace Library.Data.Entities
{
    using System.Collections.Generic;

    public class CARTE
    {
        public CARTE()
        {
            IMPRUMUTs = new List<IMPRUMUT>();
        }

        public int CarteId { get; set; }
        public string Titlu { get; set; }

        public int AutorId { get; set; }
        public int GenId { get; set; }
        public AUTOR AUTOR { get; set; }
        public GEN GEN { get; set; }

        public ICollection<IMPRUMUT> IMPRUMUTs { get; set; }
    }
}
