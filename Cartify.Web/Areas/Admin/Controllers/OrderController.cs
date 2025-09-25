using Cartify.Entities.Models;
using Cartify.Entities.Repositories;
using Cartify.Entities.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Cartify.Utilities;

namespace Cartify.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrderController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        [BindProperty]
        public  OrderVM OrderVM { get; set; }
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateOrderDetails()
        {
            var orderHeaderFromDb = _unitOfWork.OrderHeader.Get(
                u => u.Id == OrderVM.OrderHeader.Id);
            if (orderHeaderFromDb == null)
                {
                return NotFound();
            }
            orderHeaderFromDb.Name = OrderVM.OrderHeader.Name;
            orderHeaderFromDb.PhoneNumber = OrderVM.OrderHeader.PhoneNumber;
            orderHeaderFromDb.Address = OrderVM.OrderHeader.Address;
            orderHeaderFromDb.City = OrderVM.OrderHeader.City;
            if (OrderVM.OrderHeader.ShippingDate != DateTime.MinValue)
            {
                orderHeaderFromDb.ShippingDate = OrderVM.OrderHeader.ShippingDate;
            }
            if(OrderVM.OrderHeader.TrackingNumber != null)
            {
                orderHeaderFromDb.TrackingNumber = OrderVM.OrderHeader.TrackingNumber;
            }
            if(OrderVM.OrderHeader.Carrier != null)
            {
                orderHeaderFromDb.Carrier = OrderVM.OrderHeader.Carrier;
            }
            _unitOfWork.OrderHeader.Update(orderHeaderFromDb);
            _unitOfWork.Complete();
            TempData["Update"] = "Order Details Updated Successfully.";
            return RedirectToAction("Details", "Order", new { orderid = orderHeaderFromDb.Id });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult StartProcess()
        {
            _unitOfWork.OrderHeader.UpdateStatus(OrderVM.OrderHeader.Id, SD.Processing, null);
            _unitOfWork.Complete();

            TempData["Update"] = "Order Status Updated Successfully.";
            return RedirectToAction("Details", "Order", new { orderid = OrderVM.OrderHeader.Id });
        }
    }
}