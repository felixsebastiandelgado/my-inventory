using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Item
    {
        [Key]
        public int UserId { get; set; }
        
        [Required(ErrorMessage = "Required.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Required.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Required.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Required.")]
        public int ContactNo { get; set; }

        [Required(ErrorMessage = "Required.")]
        public string Password { get; set; }
    }
}
