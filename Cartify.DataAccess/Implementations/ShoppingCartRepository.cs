using Cartify.DataAccess.Data;
using Cartify.Entities.Models;
using Cartify.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartify.DataAccess.Implementations
{
    public class ShoppingCartRepository : GenericRepository<ShoppingCart>, IShoppingCartRepository
    {
        private readonly ApplicationDbContext _context;
        public ShoppingCartRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public int IncreseCount(ShoppingCart cart, int count)
        {
            cart.Count += count;
            return cart.Count;
        }
        public int DecreaseCount(ShoppingCart cart, int count)
        {
            cart.Count -= count;
            return cart.Count;
        }
    }
}
