namespace LibraryEntityFramework.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CITITOR")]
    public partial class CITITOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CITITOR()
        {
            IMPRUMUTs = new HashSet<IMPRUMUT>();
        }

        public int CititorId { get; set; }

        [Required]
        [StringLength(15)]
        public string Nume { get; set; }

        [Required]
        [StringLength(15)]
        public string Prenume { get; set; }

        [Required]
        [StringLength(50)]
        public string Adresa { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        public int Stare { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IMPRUMUT> IMPRUMUTs { get; set; }
    }
}
