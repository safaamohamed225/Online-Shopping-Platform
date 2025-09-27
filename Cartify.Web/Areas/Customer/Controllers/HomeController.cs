using Cartify.DataAccess.Implementations;
using Cartify.Entities.Models;
using Cartify.Entities.Repositories;
using Cartify.Entities.ViewModels;
using Cartify.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using X.PagedList.Extensions;

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
        public IActionResult Index(int? page)
        {
            var pageNumber = page ?? 1;
            int pageSize = 8;

            var productList = _unitOfWork.Product.GetAll().ToPagedList(pageNumber, pageSize);
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
        public IActionResult Details(ShoppingCart shoppingCart)
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            shoppingCart.ApplicationUserId = claim.Value;

        
            shoppingCart.Id = 0;

            ShoppingCart Cartobj = _unitOfWork.ShoppingCart.Get(
                u => u.ApplicationUserId == claim.Value && u.ProductId == shoppingCart.ProductId);

            if (Cartobj == null)
            {
              
                _unitOfWork.ShoppingCart.Add(shoppingCart);
                _unitOfWork.Complete();

            
                int count = _unitOfWork.ShoppingCart
                                .GetAll(x => x.ApplicationUserId == claim.Value)
                                .ToList()
                                .Count();
                HttpContext.Session.SetInt32(SD.SessionKey, count);
            }
            else
            {
          
                _unitOfWork.ShoppingCart.IncreseCount(Cartobj, shoppingCart.Count);
                _unitOfWork.Complete();
            }

            return RedirectToAction("Index");
        }
    }
}
