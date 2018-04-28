namespace LibraryEntityFramework.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AUTOR")]
    public partial class AUTOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AUTOR()
        {
            CARTEs = new HashSet<CARTE>();
        }

        public int AutorId { get; set; }

        [Required]
        [StringLength(20)]
        public string Nume { get; set; }

        [Required]
        [StringLength(20)]
        public string Prenume { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CARTE> CARTEs { get; set; }
    }
}
