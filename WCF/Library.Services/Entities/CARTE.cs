using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Library.Services.Entities
{
    [DataContract(IsReference = true)]
    public class CARTE
    {
        [DataMember]
        public int CarteId { get; set; }

        [DataMember]
        public int AutorId { get; set; }

        [DataMember]
        public string Titlu { get; set; }

        [DataMember]
        public int GenId { get; set; }

        [DataMember]
        public AUTOR AUTOR { get; set; }

        [DataMember]
        public GEN GEN { get; set; }

        [DataMember]
        public ICollection<IMPRUMUT> IMPRUMUTs { get; set; }
    }
}
