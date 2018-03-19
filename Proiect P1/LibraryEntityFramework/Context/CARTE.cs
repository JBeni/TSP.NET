namespace LibraryEntityFramework.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CARTE")]
    public partial class CARTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CARTE()
        {
            IMPRUMUTs = new HashSet<IMPRUMUT>();
        }

        public int CarteId { get; set; }

        public int AutorId { get; set; }

        [Required]
        [StringLength(50)]
        public string Titlu { get; set; }

        public int GenId { get; set; }

        public virtual AUTOR AUTOR { get; set; }

        public virtual GEN GEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IMPRUMUT> IMPRUMUTs { get; set; }
    }
}
