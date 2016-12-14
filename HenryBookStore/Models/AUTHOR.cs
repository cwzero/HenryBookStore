namespace HenryBookStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AUTHOR")]
    public partial class AUTHOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AUTHOR()
        {
            WROTEs = new HashSet<WROTE>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AUTHOR_NUM { get; set; }

        [StringLength(50)]
        public string AUTHOR_LAST { get; set; }

        [StringLength(50)]
        public string AUTHOR_FIRST { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WROTE> WROTEs { get; set; }
    }
}
