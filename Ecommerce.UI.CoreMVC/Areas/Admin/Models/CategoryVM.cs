using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.UI.CoreMVC.Areas.Admin.Models
{
    public class CategoryVM
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
