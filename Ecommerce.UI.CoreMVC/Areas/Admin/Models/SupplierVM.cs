using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.UI.CoreMVC.Areas.Admin.Models
{
    public class SupplierVM
    {
        public int SupplierID { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PhoneNummer { get; set; }
        public bool IsActive { get; set; }
    }
}
