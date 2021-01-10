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
    public class CategoryController : Controller
    {
        ICategoryBLL categoryBLL;

        public CategoryController(ICategoryBLL catBLL)
        {
            categoryBLL = catBLL;
        }

        [HttpPost]
        public IActionResult GetCategoryList([FromBody] List<CategoryVM> categories)
        {
            if (categories==null)
            {
                ViewBag.Message = "Kategoriler listelenemiyor";
            }
      

            return PartialView("_categoriesList", categories);

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Update()
        {
            return View();
        }
      

        public IActionResult AddCategory()
        {
            return View();
        }
    }
}
