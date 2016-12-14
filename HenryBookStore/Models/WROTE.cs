namespace HenryBookStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WROTE")]
    public partial class WROTE
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string BOOK_CODE { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AUTHOR_NUM { get; set; }

        public int? SEQUENCE { get; set; }

        public virtual AUTHOR AUTHOR { get; set; }

        public virtual BOOK BOOK { get; set; }
    }
}
