namespace LibraryEntityFramework.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("REVIEW")]
    public partial class REVIEW
    {
        public int ReviewId { get; set; }

        public int ImprumutId { get; set; }

        [Required]
        [StringLength(4096)]
        public string Text { get; set; }

        public virtual IMPRUMUT IMPRUMUT { get; set; }
    }
}
