using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCScaffolding.Models
{
    public class UserExtra
    {
        [Required]
        [MaxLength(40)]
        [Display(Name = "Voornaam")]
        public string Firstname { get; set; }
        [Required]
        [MaxLength(40)]
        [Display(Name = "Achternaam")]
        public string Lastname { get; set; }
        public string City { get; set; }
    }
}
