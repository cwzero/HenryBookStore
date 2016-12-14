namespace HenryBookStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BRANCH")]
    public partial class BRANCH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BRANCH()
        {
            INVENTORies = new HashSet<INVENTORY>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BRANCH_NUM { get; set; }

        [StringLength(50)]
        public string BRANCH_NAME { get; set; }

        [StringLength(50)]
        public string BRANCH_LOCATION { get; set; }

        public int? NUM_EMPLOYEES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVENTORY> INVENTORies { get; set; }
    }
}
