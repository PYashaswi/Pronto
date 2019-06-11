namespace ProntoApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblImage")]
    public partial class tblImage
    {
        [StringLength(50)]
        public string tblImageID { get; set; }

        [Column(TypeName = "image")]
        [Required]
        public byte[] Image { get; set; }

        public int tblImageTypeID { get; set; }

        public int tblStatusID { get; set; }

        [Required]
        [StringLength(50)]
        public string PackageID { get; set; }

        public bool IsActive { get; set; }

        [Required]
        [StringLength(50)]
        public string tblManifestPackageID { get; set; }

        public virtual tblImageType tblImageType { get; set; }

        public virtual tblManifestPackage tblManifestPackage { get; set; }

        public virtual tblStatu tblStatu { get; set; }
    }
}
