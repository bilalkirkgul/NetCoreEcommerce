using Ecommerce.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.BLL.Abstract
{
    public interface ICategoryBLL:IBaseBLL<Category>
    {
        ICollection<Category> GetAllActive();
    }
}
