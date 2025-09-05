using Cartify.DataAccess.Data;
using Cartify.Entities.Models;
using Cartify.Entities.Repositories;
using Cartify.Entities.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;

namespace Cartify.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _env;
        public ProductController(IUnitOfWork unitOfWork, IWebHostEnvironment env)
        {
            _unitOfWork = unitOfWork;
            _env = env;
        }
        public IActionResult Index()
        {      
            return View();
        }

        public IActionResult GetAll()
        {
            var productList = _unitOfWork.Product.GetAll(includes: "Category");
            return Json(new { data = productList });
        }
        [HttpGet]
        public IActionResult Create()
        {
            ProductVM productVM = new ProductVM()
            {
                Product = new Product(),
                CategoryList = _unitOfWork.Category.GetAll().Select(c=> new SelectListItem
                {
                    Text = c.Name,
                    Value = c.Id.ToString()
                })
            };  
            return View(productVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ProductVM productVM, IFormFile? file)
        {
            if (ModelState.IsValid)
            {
                string rootPath = _env.WebRootPath;

            if(file != null)
            {
                string fileName = Guid.NewGuid().ToString();
                var uploads = Path.Combine(rootPath, @"Images/Products");
                var extension = Path.GetExtension(file.FileName);
                using (var fileStreams = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
                {
                    file.CopyTo(fileStreams);
                }
                productVM.Product.Image = @"/Images/Products/" + fileName + extension;
            }

         
                _unitOfWork.Product.Add(productVM.Product);
                _unitOfWork.Complete();
                TempData["Create"] ="Data has been created successfully";
                return RedirectToAction("Index");
            }

            return View(productVM);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var product = _unitOfWork.Product.Get(c => c.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            ProductVM productVM = new ProductVM()
            {
                Product = product,
                CategoryList = _unitOfWork.Category.GetAll().Select(c => new SelectListItem
                {
                    Text = c.Name,
                    Value = c.Id.ToString()
                })
            };
            return View(productVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ProductVM productVM, IFormFile? file)
        {
            if (ModelState.IsValid)
            {
                string rootPath = _env.WebRootPath;

                if (file != null)
                {
                    string fileName = Guid.NewGuid().ToString();
                    var uploads = Path.Combine(rootPath, @"Images/Products");
                    var extension = Path.GetExtension(file.FileName);

                    if(productVM.Product.Image != null)
                    {
                        var oldImagePath = Path.Combine(rootPath, productVM.Product.Image.TrimStart('/'));
                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }
                    using (var fileStreams = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
                    {
                        file.CopyTo(fileStreams);
                    }
                    productVM.Product.Image = @"/Images/Products/" + fileName + extension;
                }
                _unitOfWork.Product.Update(productVM.Product);
                _unitOfWork.Complete();
                TempData["Update"] = "Data has been updated successfully";
                return RedirectToAction("Index");
            }
            return View(productVM.Product);
        }

        //[HttpGet]
        //public IActionResult Delete(int id)
        //{
        //    var product = _unitOfWork.Product.Get(c => c.Id == id);
        //    if (product == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(product);
        //}
        [HttpDelete]
        //[ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            var product = _unitOfWork.Product.Get(c => c.Id == id);
            if (product == null)
            {
                return Json( new{ success = false, message = "Error while deleting"});
            }

            _unitOfWork.Product.Remove(product);
            if (product.Image != null)
            {
                string rootPath = _env.WebRootPath;
                var oldImagePath = Path.Combine(rootPath, product.Image.TrimStart('/'));
                if (System.IO.File.Exists(oldImagePath))
                {
                    System.IO.File.Delete(oldImagePath);
                }
            }  
            _unitOfWork.Complete();
            return Json(new { success = true, message = "Delete Successful" });          
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var product = _unitOfWork.Product.Get(c => c.Id == id, include: "Category");
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
    }
}
