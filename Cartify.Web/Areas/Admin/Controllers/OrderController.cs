using Cartify.Entities.Repositories;
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

        public IActionResult GetData()
        {
            IEnumerable<Entities.Models.OrderHeader> objOrderHeaders 
                = _unitOfWork.OrderHeader.GetAll(includes: "ApplicationUser");

            return Json(new { data = objOrderHeaders });
        }
    }
}