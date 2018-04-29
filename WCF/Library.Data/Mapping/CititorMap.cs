using Library.Data.Entities;
using System.Data.Entity.ModelConfiguration;


namespace Library.Data.Mapping
{
    public class CititorMap : EntityTypeConfiguration<CITITOR>
    {
        public CititorMap()
        {
            HasKey(t => t.CititorId);

            ToTable("CITITOR");
            Property(t => t.CititorId).HasColumnName("CititorId");
            Property(t => t.Nume).HasColumnName("Nume").IsRequired().HasMaxLength(15);
            Property(t => t.Prenume).HasColumnName("Prenume").IsRequired().HasMaxLength(15);
            Property(t => t.Adresa).HasColumnName("Adresa").IsRequired().HasMaxLength(50);
            Property(t => t.Email).HasColumnName("Email").IsRequired().HasMaxLength(50);
            Property(t => t.Stare).HasColumnName("Stare").IsRequired().IsRequired();
        }
    }
}
