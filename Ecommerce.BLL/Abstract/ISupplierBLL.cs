using Ecommerce.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.BLL.Abstract
{
    public interface ISupplierBLL:IBaseBLL<Supplier>
    {
        ICollection<Supplier> GetSuppliers();
    }
}
