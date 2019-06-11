namespace ProntoApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblOrder")]
    public partial class tblOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblOrder()
        {
            tblOrderProducts = new HashSet<tblOrderProduct>();
        }

        [StringLength(50)]
        public string tblOrderID { get; set; }

        [Required]
        [StringLength(50)]
        public string InvoiceID { get; set; }

        [Required]
        [StringLength(50)]
        public string DeliveryAddressID { get; set; }

        public double AmountPaid { get; set; }

        [Required]
        [StringLength(50)]
        public string tblUserID { get; set; }

        public int tblStatusID { get; set; }

        [Required]
        [StringLength(250)]
        public string Comments { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime ModifiedAt { get; set; }

        public virtual tblStatu tblStatu { get; set; }

        public virtual tblUser tblUser { get; set; }

        public virtual tblUserAddress tblUserAddress { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrderProduct> tblOrderProducts { get; set; }
    }
}
