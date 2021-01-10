using Ecommerce.Core.DataAccess;
using Ecommerce.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.DAL.Abstract
{
    public interface IUserDAL:IRepository<User>
    {
    }
}
