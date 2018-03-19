namespace LibraryEntityFramework.Context
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelDatabaseFirst : DbContext
    {
        public ModelDatabaseFirst()
            : base("name=ModelDatabaseFirst")
        {
        }

        public virtual DbSet<AUTOR> AUTORs { get; set; }
        public virtual DbSet<CARTE> CARTEs { get; set; }
        public virtual DbSet<CITITOR> CITITORs { get; set; }
        public virtual DbSet<GEN> GENs { get; set; }
        public virtual DbSet<IMPRUMUT> IMPRUMUTs { get; set; }
        public virtual DbSet<REVIEW> REVIEWs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AUTOR>()
                .Property(e => e.Nume)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AUTOR>()
                .Property(e => e.Prenume)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AUTOR>()
                .HasMany(e => e.CARTEs)
                .WithRequired(e => e.AUTOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CARTE>()
                .Property(e => e.Titlu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CARTE>()
                .HasMany(e => e.IMPRUMUTs)
                .WithRequired(e => e.CARTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CITITOR>()
                .Property(e => e.Nume)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CITITOR>()
                .Property(e => e.Prenume)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CITITOR>()
                .Property(e => e.Adresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CITITOR>()
                .Property(e => e.Email)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CITITOR>()
                .HasMany(e => e.IMPRUMUTs)
                .WithRequired(e => e.CITITOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GEN>()
                .Property(e => e.Descriere)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GEN>()
                .HasMany(e => e.CARTEs)
                .WithRequired(e => e.GEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IMPRUMUT>()
                .HasMany(e => e.REVIEWs)
                .WithRequired(e => e.IMPRUMUT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<REVIEW>()
                .Property(e => e.Text)
                .IsUnicode(false);
        }
    }
}
