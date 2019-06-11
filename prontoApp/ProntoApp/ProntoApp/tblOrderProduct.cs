namespace ProntoApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblOrderProduct")]
    public partial class tblOrderProduct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblOrderProduct()
        {
            tblManifestPackages = new HashSet<tblManifestPackage>();
        }

        [StringLength(50)]
        public string tblOrderProductID { get; set; }

        [Required]
        [StringLength(50)]
        public string tblOrderID { get; set; }

        [Required]
        [StringLength(50)]
        public string tblProductID { get; set; }

        public int Quantity { get; set; }

        public bool IsActive { get; set; }

        public int DeliveredQuantity { get; set; }

        public int tblStatusID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblManifestPackage> tblManifestPackages { get; set; }

        public virtual tblOrder tblOrder { get; set; }

        public virtual tblProduct tblProduct { get; set; }

        public virtual tblStatu tblStatu { get; set; }
    }
}
