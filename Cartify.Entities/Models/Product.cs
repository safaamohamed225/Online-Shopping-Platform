using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartify.Entities.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required, Length(5, 50)]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        public string Image { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
