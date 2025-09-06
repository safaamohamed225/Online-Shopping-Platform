using Cartify.Entities.Repositories;
using Cartify.Entities.ViewModels;
using Microsoft.AspNetCore.Mvc;

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

        //public IActionResult Details(int id)
        //{
        //    ShoppingCart cart = new ShoppingCart()
        //    {
        //        Product = _unitOfWork.Product.Get(p => p.Id == id, include: "Category"),
        //        Count = 1
        //    };
        //    return View(cart);
        //}


        public IActionResult Details(int id)
        {
            var product = _unitOfWork.Product.Get(p => p.Id == id, include: "Category");

            // Check if product exists
            if (product == null)
            {
                return NotFound(); // Returns 404 page
                                   // Or redirect: return RedirectToAction("Index");
            }

            ShoppingCart cart = new ShoppingCart()
            {
                Product = product,
                Count = 1
            };

            return View(cart);
        }
    }
}
