using Cartify.Entities.Models;
using Cartify.Entities.Repositories;
using Cartify.Entities.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Cartify.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrderController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public OrderController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetData()
        {
            IEnumerable<OrderHeader> objOrderHeaders 
                = _unitOfWork.OrderHeader.GetAll(includes: "ApplicationUser");

            return Json(new { data = objOrderHeaders });
        }

        //[HttpGet]
        //public IActionResult Details(int orderid)
        //{
        //    OrderVM orderVM = new()
        //    {
        //        OrderHeader = _unitOfWork.OrderHeader.Get(
        //            u => u.Id == orderid, include: "ApplicationUser"),
        //        OrderDetails = _unitOfWork.OrderDetail.GetAll(
        //            u => u.OrderHeaderId == orderid, includes: "Product")
        //    };
        //    return View(orderVM);   
        //}

        [HttpGet]
        public IActionResult Details(int orderid)
        {
            var orderHeader = _unitOfWork.OrderHeader.Get(
                u => u.Id == orderid, include: "ApplicationUser");

            if (orderHeader == null)
            {
                return NotFound();
            }

            var orderDetails = _unitOfWork.OrderDetail.GetAll(
                u => u.OrderHeaderId == orderid, includes: "Product");

            OrderVM orderVM = new()
            {
                OrderHeader = orderHeader,
                OrderDetails = orderDetails
            };

            return View(orderVM);
        }

    }
}