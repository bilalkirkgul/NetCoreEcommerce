using Ecommerce.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Model.Entities
{
   public class Supplier:BaseEntity
    {
        public Supplier()
        {
            IsActive = true;
        }
        public string CompanyName { get; set; }

        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PhoneNummer { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
