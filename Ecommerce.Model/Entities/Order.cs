using Ecommerce.Core.Entity;
using Ecommerce.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Model.Entities
{
    public class Order:BaseEntity
    {
        public Order()
        {
            IsActive = true;
        }
        public DateTime OrderDate { get; set; }
        public string ShipAddress { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }

        public EnumOrderState OrderState { get; set; }
        public EnumPaymentTypes PaymentTypes { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
