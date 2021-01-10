using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.UI.CoreMVC.Areas.Admin.Models
{
    public class ProductVM
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductImgUrl { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public string BrandName { get; set; }
        public string CategoryName { get; set; }
        public string CompanyName { get; set; }
        public bool IsActive { get; set; }
        public bool Continued { get; set; }
        public bool DisCounted { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
