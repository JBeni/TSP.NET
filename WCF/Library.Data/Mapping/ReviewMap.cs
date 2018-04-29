using Library.Data.Entities;
using System.Data.Entity.ModelConfiguration;


namespace Library.Data.Mapping
{
    public class ReviewMap : EntityTypeConfiguration<REVIEW>
    {
        public ReviewMap()
        {
            HasKey(t => t.ReviewId);

            ToTable("REVIEW");
            Property(t => t.ReviewId).HasColumnName("ReviewId");
            Property(t => t.Text).HasColumnName("Text").IsRequired().HasMaxLength(4096);
        }
    }
}
