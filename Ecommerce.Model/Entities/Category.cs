using Ecommerce.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Model.Entities
{
  public class Category:BaseEntity
    {
        public Category()
        {
            IsActive = true;
        }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
