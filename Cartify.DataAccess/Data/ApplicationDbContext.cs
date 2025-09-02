
using Cartify.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Cartify.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {          
        }

        public DbSet<Category> Categories { get; set; }
    }
}
