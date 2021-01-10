using Ecommerce.Core.DataAccess.EntityFramework;
using Ecommerce.DAL.Abstract;
using Ecommerce.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.DAL.Concrete.Repository
{
    class CategoryRepository:EFRepositoryBase<Category, EcommerceDbContext>,ICategoryDAL
    {
    }
}
