using Ecommerce.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.BLL.Abstract
{
    public interface IProductBLL : IBaseBLL<Product>
    {

        ICollection<Product> GetProducts();
        ICollection<Product> GetProductActive();
        ICollection<Product> GetProductByBrand(int ID);
        ICollection<Product> GetByCategory(int id);

        ICollection<Product> ProductGetSearch(string name);

        Product GetCartItem(int entityID);
    }
}
