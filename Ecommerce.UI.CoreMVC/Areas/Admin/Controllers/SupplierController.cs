using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.BLL.Abstract;
using Ecommerce.Model.Entities;
using Ecommerce.UI.CoreMVC.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.UI.CoreMVC.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class SupplierController : Controller
    {

        ISupplierBLL supplierBLL;

        public SupplierController(ISupplierBLL supplier)
        {
            supplierBLL = supplier;
        }
      

        [HttpPost]
        public IActionResult GetSupplierList([FromBody] List<SupplierVM> suppliers)
        {
            if (suppliers == null)
            {
                ViewBag.Message = "Tedarikçilere ulaşamadık";
            }
            return PartialView("_supplierList", suppliers);
        }



        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Update()
        {
            return View();
        }


        public IActionResult AddSupplier()
        {
            return View();
        }

    }
}
