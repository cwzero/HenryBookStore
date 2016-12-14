namespace HenryBookStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INVENTORY")]
    public partial class INVENTORY
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string BOOK_CODE { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BRANCH_NUM { get; set; }

        public int? ON_HAND { get; set; }

        public virtual BOOK BOOK { get; set; }

        public virtual BRANCH BRANCH { get; set; }
    }
}
