using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Service.WebAPI.Models
{
    public class BrandDTO
    {
        public int BrandID { get; set; }
        public string BrandName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
