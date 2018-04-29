using Library.Data.Entities;
using System.Data.Entity.ModelConfiguration;


namespace Library.Data.Mapping
{
    public class AutorMap : EntityTypeConfiguration<AUTOR>
    {
        public AutorMap()
        {
            HasKey(t => t.AutorId);

            ToTable("AUTOR");
            Property(t => t.AutorId).HasColumnName("AutorId");
            Property(t => t.Nume).HasColumnName("Nume").HasMaxLength(20).IsRequired();
            Property(t => t.Prenume).HasColumnName("Prenume").HasMaxLength(20).IsRequired();
        }
    }
}
