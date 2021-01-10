using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.UI.CoreMVC.Areas.Admin.Models
{
    public class BrandVM
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

    }
}
