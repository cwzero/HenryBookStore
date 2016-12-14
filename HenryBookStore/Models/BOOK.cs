namespace HenryBookStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BOOK")]
    public partial class BOOK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOOK()
        {
            INVENTORies = new HashSet<INVENTORY>();
            WROTEs = new HashSet<WROTE>();
        }

        [Key]
        [StringLength(4)]
        public string BOOK_CODE { get; set; }

        [StringLength(50)]
        public string TITLE { get; set; }

        [StringLength(2)]
        public string PUBLISHER_CODE { get; set; }

        [StringLength(3)]
        public string TYPE { get; set; }

        public decimal? PRICE { get; set; }

        public string PAPERBACK { get; set; }

        public virtual PUBLISHER PUBLISHER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVENTORY> INVENTORies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WROTE> WROTEs { get; set; }
    }
}
