using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.UI.CoreMVC.Areas.Admin.Helper;
using Ecommerce.UI.CoreMVC.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.UI.CoreMVC.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Authorize(Roles = "Admin")]


    public class ProductController : Controller
    {
        [Obsolete]
        IHostingEnvironment _environment;

        [Obsolete]
        public ProductController(IHostingEnvironment hosting)
        {
            _environment = hosting;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult AddProduct()
        {
            return View();
        }


        public IActionResult Update()
        {
            return View();
        }


        [HttpPost]
        public IActionResult GetProductList([FromBody] List<ProductVM> products)
        {
            if (products == null)
            {
                ViewBag.Message = "Ürünlere ulaşamadık";
            }
            return PartialView("_singleProductList", products);
        }
        [HttpPost]
        public IActionResult GetBrandList([FromBody] List<BrandVM> brands)
        {
            if (brands == null)
            {
                ViewBag.Message = "Marka adına ulaşılamadı";
            }
            return PartialView("_singleBrandFilters", brands);
        }

        [HttpPost]
        public IActionResult GetCategoryList([FromBody] List<CategoryVM> categories)
        {
            if (categories == null)
            {
                ViewBag.Message = "Kategori adına ulaşamadık";
            }
            return PartialView("_singleCategoryFilters", categories);
        }

        [HttpPost]
        [Obsolete]
        public IActionResult AddProductImg([FromForm] IFormFile file)
        {
            string imgProductUrl = ImgHelpers.GetImageUrl(file, _environment);

            return Ok(new {imgUrl=imgProductUrl });
        }

    }
}
