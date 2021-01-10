using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.BLL.Abstract;
using Ecommerce.UI.CoreMVC.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.UI.CoreMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class BrandController : Controller
    {

        IBrandBLL brandBLL;
        public BrandController(IBrandBLL brand)
        {
            brandBLL = brand;
        }

        [HttpPost]
        public IActionResult GetBrandList([FromBody] List<BrandVM> brands)
        {
            if (brands==null)
            {
                ViewBag.Message = "Markalar Listelenemiyor";

            }
            return PartialView("_brandList", brands);
        }



        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddBrand()
        {
            return View();
        }

        public IActionResult Update()
        {
            return View();
        }

      

    }
}
