using Cartify.DataAccess.Data;
using Cartify.Entities.Models;
using Cartify.Utilities;
using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.CSharp.Syntax;
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
            // Apply migrations if needed
            try
            {
                if (_context.Database.GetPendingMigrations().Any())
                {
                    _context.Database.Migrate();
                }
            }
            catch (Exception)
            {
                throw;
            }
            if (!await _roleManager.RoleExistsAsync(SD.AdminRole))
            {
                await _roleManager.CreateAsync(new IdentityRole(SD.AdminRole));
                await _roleManager.CreateAsync(new IdentityRole(SD.EditorRole));
                await _roleManager.CreateAsync(new IdentityRole(SD.CustomerRole));

                await _userManager.CreateAsync(new ApplicationUser
                {

                    UserName = "admin@cartify.com",
                    Email = "admin@cartify.com",
                    EmailConfirmed = true,
                    PhoneNumber = "1112223333",
                    Name = "Admin",
                    City = "New York",
                    Address = "123 Admin St"
                }, "Pa$word@123");

                ApplicationUser user = await _context.ApplicationUsers.FirstOrDefaultAsync(u => u.Email == "admin@cartify.com");
                await _userManager.AddToRoleAsync(user, SD.AdminRole);
            }
            return;
        }
       
    }
}
