using System.Runtime.Serialization;


namespace Library.Services.Entities
{
    [DataContract(IsReference = true)]
    public class REVIEW
    {
        [DataMember]
        public int ReviewId { get; set; }

        [DataMember]
        public int ImprumutId { get; set; }

        [DataMember]
        public string Text { get; set; }

        [DataMember]
        public IMPRUMUT IMPRUMUT { get; set; }
    }
}
