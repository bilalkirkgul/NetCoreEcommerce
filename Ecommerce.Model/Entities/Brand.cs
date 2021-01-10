using Ecommerce.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Model.Entities
{
   public class Brand:BaseEntity
    {
        public Brand()
        {
            IsActive = true;
            
        }

        public string BrandName { get; set; }
        public string Description { get; set; }

        public ICollection<Product> Products { get; set; }

    }
}
