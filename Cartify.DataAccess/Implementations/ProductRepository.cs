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
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public void Update(Product product)
        {
            var objFromDb = _context.Products.FirstOrDefault(c => c.Id == product.Id);
            if (objFromDb is not null)
            {
                objFromDb.Name = product.Name;
                objFromDb.Description = product.Description;
            }
        }
    }
}
