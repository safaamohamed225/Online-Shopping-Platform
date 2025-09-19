using Cartify.DataAccess.Data;
using Cartify.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Cartify.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = SD.AdminRole)]
    [Area("Admin")]
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity!;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            var userId = claim.Value;
            var users = _context.ApplicationUsers.Where(x => x.Id != userId).ToList();
            return View(users);
        }

        public IActionResult LockUnLock(string? id)
        {
            var user = _context.ApplicationUsers.FirstOrDefault(x => x.Id == id);
            if(user ==null)
            {
                return NotFound();
            }
            if(user.LockoutEnd != null && user.LockoutEnd > DateTime.Now)
            {
                //user is locked and we need to unlock them
                user.LockoutEnd = DateTime.Now;
            }
            else
            {
                user.LockoutEnd = DateTime.Now.AddYears(1);
            }

            _context.SaveChanges();
            return RedirectToAction(nameof(Index), new { area = "Admin"});
        }
    }
}
