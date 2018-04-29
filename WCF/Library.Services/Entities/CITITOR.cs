using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Library.Services.Entities
{
    [DataContract(IsReference = true)]
    public class CITITOR
    {
        [DataMember]
        public int CititorId { get; set; }

        [DataMember]
        public string Nume { get; set; }

        [DataMember]
        public string Prenume { get; set; }

        [DataMember]
        public string Adresa { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public int Stare { get; set; }

        [DataMember]
        public ICollection<IMPRUMUT> IMPRUMUTs { get; set; }
    }
}
