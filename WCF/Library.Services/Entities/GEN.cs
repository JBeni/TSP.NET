using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Library.Services.Entities
{
    [DataContract(IsReference = true)]
    public class GEN
    {
        [DataMember]
        public int GenId { get; set; }

        [DataMember]
        public string Descriere { get; set; }

        [DataMember]
        public ICollection<CARTE> CARTEs { get; set; }
    }
}
