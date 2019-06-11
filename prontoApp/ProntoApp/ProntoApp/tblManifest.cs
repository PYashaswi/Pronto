namespace ProntoApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblManifest")]
    public partial class tblManifest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblManifest()
        {
            tblManifestPackages = new HashSet<tblManifestPackage>();
        }

        [StringLength(50)]
        public string tblManifestId { get; set; }

        public double Volume { get; set; }

        public double Weight { get; set; }

        public int PackageCount { get; set; }

        [Required]
        [StringLength(50)]
        public string tblUserId { get; set; }

        public int tblStatusID { get; set; }

        [Required]
        [StringLength(250)]
        public string Remarks { get; set; }

        public virtual tblStatu tblStatu { get; set; }

        public virtual tblUser tblUser { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblManifestPackage> tblManifestPackages { get; set; }
    }
}
