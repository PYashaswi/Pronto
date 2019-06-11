using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ProntoApp
{
    public class login
    {
        [StringLength(50)]
        public string userID { get; set; }
        [Required]
        [StringLength(50)]
        public string password { get; set; }
    }
}
