namespace Library.Data.Entities
{
    using System;
    using System.Collections.Generic;

    public class IMPRUMUT
    {
        public IMPRUMUT()
        {
            REVIEWs = new List<REVIEW>();
        }

        public int ImprumutId { get; set; }
        public DateTime DataImprumut { get; set; }
        public DateTime DataScadenta { get; set; }
        public DateTime? DataRestituire { get; set; }

        public int CarteId { get; set; }
        public int CititorId { get; set; }
        public CARTE CARTE { get; set; }
        public CITITOR CITITOR { get; set; }

        public ICollection<REVIEW> REVIEWs { get; set; }
    }
}
