namespace Library.Data.Entities
{
    public class REVIEW
    {
        public int ReviewId { get; set; }
        public string Text { get; set; }

        public int ImprumutId { get; set; }

        public IMPRUMUT IMPRUMUT { get; set; }
    }
}
