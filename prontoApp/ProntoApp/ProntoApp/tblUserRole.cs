namespace ProntoApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblUserRole")]
    public partial class tblUserRole
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string tblUserID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tblRoleID { get; set; }

        public bool IsActive { get; set; }

        public virtual tblRole tblRole { get; set; }

        public virtual tblUser tblUser { get; set; }
    }
}
