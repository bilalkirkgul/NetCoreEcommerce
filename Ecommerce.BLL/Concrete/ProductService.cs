using Ecommerce.BLL.Abstract;
using Ecommerce.DAL.Abstract;
using Ecommerce.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ecommerce.BLL.Concrete
{
    class ProductService : IProductBLL
    {
        IProductDAL productDAL;
        public ProductService( IProductDAL dal)
        {
            productDAL = dal;
        }
        void Check(Product product)
        {
            if (string.IsNullOrEmpty(product.ProductName)||string.IsNullOrEmpty(product.Stock.ToString())||string.IsNullOrEmpty(product.Price.ToString())||string.IsNullOrEmpty(product.Description))
            {
                throw new Exception("Ürün Adı, Açıklaması, Stok Adedi ve Fiyatı boş geçilemez");
            }
            if (product.Stock<=0)
            {
                throw new Exception("En az bir ürün kaydetmelisiniz");
            }
        }

        public void Insert(Product entity)
        {
            Check(entity);
            productDAL.Add(entity);

        }

        public void Update(Product entity)
        {
            Check(entity);
            productDAL.Update(entity);
        }

        public void Delete(Product entity)
        {
            entity.IsActive = false;
            productDAL.Update(entity);
        }

        public void DeleteByID(int entityID)
        {
            Product product = Get(entityID);
            product.IsActive = false;
            productDAL.Update(product);

        }
      
        public Product Get(int entityID)
        {
            return productDAL.Get(a => a.ID == entityID&&a.Continued&&a.IsActive, a=>a.Brand,a=>a.Category,a=>a.Supplier);

        }

        public ICollection<Product> GetAll()
        {
            return productDAL.GetAll();
        }

        //son 10 ürünü listele  Bll eklendi
        public ICollection<Product> GetProducts()
        {
            return productDAL.GetAll(a => a.Continued && a.IsActive, a => a.Category, a => a.Brand, a => a.Supplier).OrderByDescending(a => a.CreatedDate).ToList();
        }
        public ICollection<Product> GetProductActive()
        {
            return productDAL.GetAll(a => a.IsActive, a => a.Category, a => a.Brand, a => a.Supplier);
        }

        //Markaya göre listele Bll eklendi
        public ICollection<Product> GetProductByBrand(int ID)
        {
            return productDAL.GetAll(a=>a.Continued&& a.IsActive&& a.BrandID==ID, a=>a.Brand, a=>a.Category,a=>a.Supplier);
        }

        //Categoriye göre listeleme Bll eklendi
        public ICollection<Product> GetByCategory(int id)
        {
            return productDAL.GetAll(a => a.Continued && a.IsActive==true && a.CategoryID == id, a => a.Brand, a => a.Category, a => a.Supplier);
        }

        public ICollection<Product> ProductGetSearch(string name)
        {            
            return productDAL.GetAll(a => a.Continued && a.IsActive && a.ProductName.ToLower().Contains(name.ToLower()), a => a.Brand, a => a.Category, a => a.Supplier);
        }

        public Product GetCartItem(int entityID)
        {
            return productDAL.Get(a => a.ID == entityID && a.Continued && a.IsActive, a => a.Brand, a => a.Category, a => a.Supplier);

        }

        public void ReduceStock(int id, short amount)
        {
            //Order Detail ve Order tam kullanılmadığı için gerek kalmadı
            Product product = productDAL.Get(a => a.ID == id);
            product.Stock-=amount;
            if (product.Stock<0)
            {
                throw new Exception("Stok adedi yetersizdir");
            }


            productDAL.Update(product);



        }

      
    }
}
