namespace ProntoApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblManifestPackage")]
    public partial class tblManifestPackage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblManifestPackage()
        {
            tblImages = new HashSet<tblImage>();
        }

        [StringLength(50)]
        public string tblManifestPackageID { get; set; }

        [Required]
        [StringLength(50)]
        public string PackageID { get; set; }

        [Required]
        [StringLength(50)]
        public string tblOrderProductID { get; set; }

        [Required]
        [StringLength(50)]
        public string tblManifestID { get; set; }

        public int DeliveredQuantity { get; set; }

        public int Quantity { get; set; }

        [Required]
        [StringLength(250)]
        public string Remarks { get; set; }

        public int tblStatusID { get; set; }

        public int Priority { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblImage> tblImages { get; set; }

        public virtual tblManifest tblManifest { get; set; }

        public virtual tblOrderProduct tblOrderProduct { get; set; }

        public virtual tblStatu tblStatu { get; set; }
    }
}
