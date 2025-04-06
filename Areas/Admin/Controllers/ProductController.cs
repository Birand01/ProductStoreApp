using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace StoreApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController:Controller
    {
        private readonly IServiceManager serviceManager;

        public ProductController(IServiceManager serviceManager)
        {
            this.serviceManager = serviceManager;
        }

        public IActionResult Index()
        {
            var model=serviceManager.ProductService.GetAllProducts(false);
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([FromForm] Product product)
        {
            if(ModelState.IsValid)
            {
                serviceManager.ProductService.CreateProduct(product);
                return RedirectToAction("Index");
            }
            return View();
           
        }
    }
}