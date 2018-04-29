using Library.Data.Entities;
using System.Data.Entity.ModelConfiguration;


namespace Library.Data.Mapping
{
    public class CarteMap : EntityTypeConfiguration<CARTE>
    {
        public CarteMap()
        {
            HasKey(t => t.CarteId);

            ToTable("CARTE");
            Property(t => t.CarteId).HasColumnName("CarteId");
            Property(t => t.Titlu).HasColumnName("Titlu").HasMaxLength(50).IsRequired();
        }
    }
}
