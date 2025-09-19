using Cartify.Entities.Models;
using Cartify.Entities.Repositories;
using Cartify.Entities.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Cartify.Web.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            var productList = _unitOfWork.Product.GetAll();
            return View(productList);
        }
        public IActionResult Details(int id)
        {
            var product = _unitOfWork.Product.Get(p => p.Id == id, include: "Category");

            // Check if product exists
            if (product == null)
            {
                return NotFound(); 
            }
            AddToCartVM cart = new AddToCartVM()
            {
                ProductId = id,
                Count = 1,
                Product = product
            };

            return View(cart);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public IActionResult Details(AddToCartVM vm)
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity!;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            ShoppingCart cart = new ShoppingCart()
            {
                ProductId = vm.ProductId,
                Count = vm.Count,
                ApplicationUserId = claim.Value
            };

            _unitOfWork.ShoppingCart.Add(cart);
            _unitOfWork.Complete();

            return RedirectToAction(nameof(Index));
        }
    }
}
