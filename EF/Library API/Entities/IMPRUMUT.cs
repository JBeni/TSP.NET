namespace LibraryEntityFramework.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IMPRUMUT")]
    public partial class IMPRUMUT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IMPRUMUT()
        {
            REVIEWs = new HashSet<REVIEW>();
        }

        public int ImprumutId { get; set; }

        public int CarteId { get; set; }

        public int CititorId { get; set; }

        public DateTime DataImprumut { get; set; }

        public DateTime DataScadenta { get; set; }

        public DateTime? DataRestituire { get; set; }

        public virtual CARTE CARTE { get; set; }

        public virtual CITITOR CITITOR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REVIEW> REVIEWs { get; set; }
    }
}
