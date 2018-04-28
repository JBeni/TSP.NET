namespace LibraryEntityFramework.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEN")]
    public partial class GEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GEN()
        {
            CARTEs = new HashSet<CARTE>();
        }

        public int GenId { get; set; }

        [Required]
        [StringLength(50)]
        public string Descriere { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CARTE> CARTEs { get; set; }
    }
}
