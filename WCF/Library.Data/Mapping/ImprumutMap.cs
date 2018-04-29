using Library.Data.Entities;
using System.Data.Entity.ModelConfiguration;


namespace Library.Data.Mapping
{
    public class ImprumutMap : EntityTypeConfiguration<IMPRUMUT>
    {
        public ImprumutMap()
        {
            HasKey(t => t.ImprumutId);

            ToTable("IMPRUMUT");
            Property(t => t.ImprumutId).HasColumnName("ImprumutId");
            Property(t => t.DataImprumut).HasColumnName("DataImprumut").IsRequired();
            Property(t => t.DataScadenta).HasColumnName("DataScadenta").IsRequired();
            Property(t => t.DataRestituire).HasColumnName("DataRestituire").IsOptional();
        }
    }
}
