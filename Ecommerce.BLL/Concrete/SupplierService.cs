using Ecommerce.BLL.Abstract;
using Ecommerce.DAL.Abstract;
using Ecommerce.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.BLL.Concrete
{
    class SupplierService : ISupplierBLL
    {
        ISupplierDAL supplierDAL;
        public SupplierService(ISupplierDAL dal)
        {
            supplierDAL = dal;
        }
        void Check(Supplier supplier)
        {
            if (string.IsNullOrEmpty(supplier.CompanyName) || string.IsNullOrEmpty(supplier.Address) || string.IsNullOrEmpty(supplier.City) || string.IsNullOrEmpty(supplier.Country))
            {
                throw new Exception("Tedarikçi İsim, Adres, Şehir ve Ülke alanları boş geçilemez");
            }
        }


        public void Insert(Supplier entity)
        {
            Check(entity);
            supplierDAL.Add(entity);
        }

        public void Update(Supplier entity)
        {
            Check(entity);
            supplierDAL.Update(entity);
        }


        public void Delete(Supplier entity)
        {
            entity.IsActive = false;
            supplierDAL.Update(entity);
        }

        public void DeleteByID(int entityID)
        {
            Supplier supplier = Get(entityID);
            supplier.IsActive = false;
            supplierDAL.Update(supplier);
        }

        public Supplier Get(int entityID)
        {
            return supplierDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Supplier> GetAll()
        {
            return supplierDAL.GetAll();
        }
        public ICollection<Supplier> GetSuppliers()//sadece aktifler
        {
            return supplierDAL.GetAll(a => a.IsActive, a => a.Products);
        }


    }
}
