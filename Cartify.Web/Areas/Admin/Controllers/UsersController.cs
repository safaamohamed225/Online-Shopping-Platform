using Cartify.DataAccess.Data;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Cartify.Web.Areas.Admin.Controllers
{
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
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            var userId = claim.Value;
            var users = _context.ApplicationUsers.Where(x => x.Id != userId).ToList();
            return View(users);
        }
    }
}
