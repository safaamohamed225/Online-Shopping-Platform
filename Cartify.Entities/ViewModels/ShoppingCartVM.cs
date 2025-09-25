using Cartify.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartify.Entities.ViewModels
{
    public class ShoppingCartVM
    {
        public IEnumerable<ShoppingCart> CartsList { get; set; }
        public decimal CartTotal { get; set; }

        public OrderHeader OrderHeader { get; set; }
    }
}
