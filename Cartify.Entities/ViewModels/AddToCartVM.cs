using Cartify.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartify.Entities.ViewModels
{
    public class AddToCartVM
    {
        public int ProductId { get; set; }
        public int Count { get; set; }
        public Product Product { get; set; }
    }

}
