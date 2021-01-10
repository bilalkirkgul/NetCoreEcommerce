using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Model.Entities
{
   public class OrderDetail
    {
     
        public int OrderID { get; set; }
        
        public int ProductID { get; set; }
        public short Quantity { get; set; }
        public decimal Price { get; set; }
        public double Discount { get; set; }

        public Order Order { get; set; }
        public Product Product { get; set; }


    }
}
