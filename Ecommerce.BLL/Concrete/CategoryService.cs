using Ecommerce.BLL.Abstract;
using Ecommerce.DAL.Abstract;
using Ecommerce.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.BLL.Concrete
{
    class CategoryService : ICategoryBLL
    {

        ICategoryDAL categoryDAL;
        public CategoryService(ICategoryDAL dal)
        {
            categoryDAL = dal;
        }

        void Check(Category category)
        {
            if (string.IsNullOrEmpty(category.CategoryName)||string.IsNullOrEmpty(category.Description))
            {
                throw new Exception("Kategori adı ve Açıklması boş geçilemez");
            }
           
        }


        public void Insert(Category entity)
        {
            Check(entity);
            categoryDAL.Add(entity);
        }

        public void Update(Category entity)
        {
            Check(entity);
            categoryDAL.Update(entity);
        }

        public void Delete(Category entity)
        {
            entity.IsActive = false;
            categoryDAL.Update(entity);
        }

        public void DeleteByID(int entityID)
        {
            Category category = Get(entityID);
            category.IsActive = false;
            categoryDAL.Update(category);
        }

        public Category Get(int entityID)
        {
           return categoryDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Category> GetAll()
        {
            return categoryDAL.GetAll();
        }
        public ICollection<Category> GetAllActive()
        {
            return categoryDAL.GetAll(a => a.IsActive);
        }

    }
}
