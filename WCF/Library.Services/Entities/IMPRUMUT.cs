using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Library.Services.Entities
{
    [DataContract(IsReference = true)]
    public class IMPRUMUT
    {
        [DataMember]
        public int ImprumutId { get; set; }

        [DataMember]
        public int CarteId { get; set; }

        [DataMember]
        public int CititorId { get; set; }

        [DataMember]
        public DateTime DataImprumut { get; set; }

        [DataMember]
        public DateTime DataScadenta { get; set; }

        [DataMember]
        public DateTime? DataRestituire { get; set; }

        [DataMember]
        public CARTE CARTE { get; set; }

        [DataMember]
        public CITITOR CITITOR { get; set; }

        [DataMember]
        public ICollection<REVIEW> REVIEWs { get; set; }
    }
}
