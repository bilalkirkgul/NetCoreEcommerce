using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.UI.CoreMVC.Models.Cart
{
    public class CartItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ProductImgUrl { get; set; }
        public string BrandNane { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public short Amount { get; set; }
        public decimal SubTotal => Price * Amount;
    }
}
