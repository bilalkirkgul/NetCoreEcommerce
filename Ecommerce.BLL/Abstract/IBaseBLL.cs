using Ecommerce.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.BLL.Abstract
{
    public interface IBaseBLL<TEntity>
        where TEntity:BaseEntity
    {
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void DeleteByID(int entityID);
        TEntity Get(int entityID);
        ICollection<TEntity> GetAll();
    }
}
