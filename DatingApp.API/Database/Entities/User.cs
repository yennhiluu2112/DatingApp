using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatingApp.DatingApp.API.Database.Entities
{
    [Table("User")]
    public class User
    {
        [Key]
        public int Id { get; set; }

        [StringLength(32)]
        [Required]
        public string UserName { get; set; }

        [StringLength(255)]
        [Required]
        public string Email { get; set; }
        
    }
}