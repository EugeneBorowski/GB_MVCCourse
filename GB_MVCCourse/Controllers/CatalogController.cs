using GB_MVCCourse.Models;
using Microsoft.AspNetCore.Mvc;

namespace GB_MVCCourse.Controllers
{
    public class CatalogController : Controller
    {
        private static Catalog _catalog = new();

        [HttpGet]
        public IActionResult Products()
        {
            return View(_catalog);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product model)
        {
            _catalog.Products.Add(model);
            return View(_catalog);
        }
    }
}
