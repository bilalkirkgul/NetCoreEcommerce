using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.UI.CoreMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.UI.CoreMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetProducts([FromBody] List<ProductVM> products)
        {
            if (products==null)
            {
                ViewBag.Message = "Ürün bulunamadı";
            }
            return PartialView("_singleProducts", products);
        }
        [HttpPost]
        public IActionResult GetBrandList([FromBody] List<BrandVM> brands)
        {
            if (brands==null)
            {
                ViewBag.Message = "Marka adına ulaşılamadı";
            }
            return PartialView("_singleBrandFilters", brands);
        }
        [HttpPost]
        public IActionResult GetCategoryList([FromBody] List<CategoryVM> categories)
        {

            if (categories==null)
            {
                ViewBag.Message = "Kategori adına ulaşılamadı";
            }
            return PartialView("_singleCategoryFilters", categories);
        }

    }
}
