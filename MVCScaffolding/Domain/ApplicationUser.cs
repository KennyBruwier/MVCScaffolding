using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCScaffolding.Domain
{
    public class ApplicationUser : IdentityUser
    {
        [MaxLength(40)]
        [Required]
        public string Firstname { get; set; }
        [MaxLength(40)]
        [Required]
        public string Lastname { get; set; }
        [MaxLength(40)]
        public string City { get; set; }
    }
}
