using Ecommerce.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Model.Entities
{
   public class Product:BaseEntity
    {
        public Product()
        {
            IsActive = true;
            Continued = true;
            DisCounted = false;
        }
        public string ProductName { get; set; }
        public string ProductImgUrl { get; set; }
        public string Description { get; set; }
        public short Stock { get; set; }
        public decimal Price { get; set; }
        public bool Continued { get; set; }
        public bool DisCounted { get; set; }

        public int BrandID { get; set; }
        public Brand Brand { get; set; }

        public int CategoryID { get; set; }

        public Category Category { get; set; }

        public int SupplierID { get; set; }
        public Supplier Supplier { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }

    }
}
