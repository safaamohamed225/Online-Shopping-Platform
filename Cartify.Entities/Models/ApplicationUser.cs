using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartify.Entities.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required, Length(5, 50)]
        public string Name { get; set; }

        public string City { get; set; }

        public string Address { get; set; }
    }
}
