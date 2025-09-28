using Cartify.DataAccess.Data;
using Cartify.Entities.Models;
using Cartify.Utilities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartify.DataAccess.DbInitializer
{
    public class DbInitializer : IDbInitializer
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _context;

        public DbInitializer(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            ApplicationDbContext context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;
        }
        public async Task InitializeAsync()
        {
            //Migration
            try
            {
                if(_context.Database.GetPendingMigrations().Count() > 0)
                {
                    _context.Database.Migrate();
                }
            }
            catch (Exception)
            {
                throw;
            }

            //Roles

            if (!await _roleManager.RoleExistsAsync(SD.AdminRole))
            {
                await _roleManager.CreateAsync(new IdentityRole(SD.AdminRole));
                await _roleManager.CreateAsync(new IdentityRole(SD.EditorRole));
                await _roleManager.CreateAsync(new IdentityRole(SD.CustomerRole));


                //Users
                await _userManager.CreateAsync(new ApplicationUser
                {
                    UserName = "AdminShopping",
                    Email = "admin@shopping.com",
                    PhoneNumber = "1112223333",
                    Name = "Administrator",
                    City = "New York",
                    Address = "123 Admin St"
                }, "Admin@password123");

                ApplicationUser user = await _context.ApplicationUsers
                    .FirstOrDefaultAsync(u => u.Email == "admin@shopping.com");

                await _userManager.AddToRoleAsync(user!, SD.AdminRole);
            }
          return;
        }
    }
}
