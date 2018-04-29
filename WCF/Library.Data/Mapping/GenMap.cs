using Library.Data.Entities;
using System.Data.Entity.ModelConfiguration;


namespace Library.Data.Mapping
{
    public class GenMap : EntityTypeConfiguration<GEN>
    {
        public GenMap()
        {
            HasKey(t => t.GenId);

            ToTable("GEN");
            Property(t => t.GenId).HasColumnName("GenId");
            Property(t => t.Descriere).HasColumnName("Descriere").IsRequired().HasMaxLength(50);
        }
    }
}
