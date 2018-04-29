using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Library.Services.Entities
{
    [DataContract(IsReference = true)]
    public class AUTOR
    {
        [DataMember]
        public int AutorId { get; set; }

        [DataMember]
        public string Nume { get; set; }

        [DataMember]
        public string Prenume { get; set; }

        [DataMember]
        public ICollection<CARTE> CARTEs { get; set; }
    }
}
