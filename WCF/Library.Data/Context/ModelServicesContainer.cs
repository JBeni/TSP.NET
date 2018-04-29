namespace Library.Data.Context
{
    using Library.Data.Entities;
    using Library.Data.Mapping;
    using System.Data.Entity;

    public partial class ModelServicesContainer : DbContext
    {
        public ModelServicesContainer() : base("ModelServicesContainer")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<AUTOR>     AUTORs     { get; set; }
        public virtual DbSet<CARTE>     CARTEs     { get; set; }
        public virtual DbSet<CITITOR>   CITITORs   { get; set; }
        public virtual DbSet<GEN>       GENs       { get; set; }
        public virtual DbSet<IMPRUMUT>  IMPRUMUTs  { get; set; }
        public virtual DbSet<REVIEW>    REVIEWs    { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new GenMap());
            modelBuilder.Configurations.Add(new AutorMap());
            modelBuilder.Configurations.Add(new CarteMap());
            modelBuilder.Configurations.Add(new CititorMap());
            modelBuilder.Configurations.Add(new ImprumutMap());
            modelBuilder.Configurations.Add(new ReviewMap());
        }
    }
}
