using Ecommerce.BLL.Abstract;
using Ecommerce.DAL.Abstract;
using Ecommerce.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.BLL.Concrete
{
    class BrandService : IBrandBLL
    {
        IBrandDAL brandDAL;

        public BrandService(IBrandDAL dal)
        {
            brandDAL = dal;
        }

        void Check(Brand brand)
        {
            if (string.IsNullOrWhiteSpace(brand.BrandName)||string.IsNullOrWhiteSpace(brand.Description))
            {
                throw new Exception("Marka adı ve açıklaması boş geçilemez");
            }
        }

        //void CheckBrandName(string brandName)
        //{
        //    ICollection<Brand> brands = brandDAL.GetAll();
        //    foreach (Brand item in brands)
        //    {
        //        if (item.BrandName==brandName)
        //        {
        //            throw new Exception("Böyle bir marka kayıtlarınızda zaten mevcut");
        //        }
        //    }
        //}


        public void Insert(Brand entity)
        {
            Check(entity);
            //CheckBrandName(entity.BrandName);
            brandDAL.Add(entity);
        }

        public void Update(Brand entity)
        {
            Check(entity);
            //CheckBrandName(entity.BrandName);
            brandDAL.Update(entity);
        }

        public void Delete(Brand entity)
        {
            entity.IsActive = false;
            brandDAL.Update(entity);

        }

        public void DeleteByID(int entityID)
        {
            Brand brand = Get(entityID);
            brand.IsActive = false;
            brandDAL.Update(brand);
        }

        public Brand Get(int entityID)
        {
            return brandDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Brand> GetAll()
        {
            return brandDAL.GetAll();
        }
        public ICollection<Brand> GetAllActive()
        {
            return brandDAL.GetAll(a=>a.IsActive);
        }

    }
}
