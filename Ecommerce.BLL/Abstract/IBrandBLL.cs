using Ecommerce.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.BLL.Abstract
{
    public interface IBrandBLL:IBaseBLL<Brand>
    {
        ICollection<Brand> GetAllActive();
    }
}
