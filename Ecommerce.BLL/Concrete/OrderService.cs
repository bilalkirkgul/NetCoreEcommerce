using Ecommerce.BLL.Abstract;
using Ecommerce.DAL.Abstract;
using Ecommerce.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.BLL.Concrete
{
    class OrderService : IOrderBLL
    {
        IOrderDAL orderDAL;

        public OrderService(IOrderDAL oDAL)
        {
            orderDAL = oDAL;
        }

        void Check(Order order)
        {
            if (order.OrderDate>DateTime.Now)
            {
                throw new Exception("Sipariş tarihi bugünden ileri tarihli olmalıdır");
            }
            if (order.ShipAddress==null)
            {
                throw new Exception("Teslimat adresi girmeniz zorunludur");
            }
        }


        public void Insert(Order entity)
        {
            Check(entity);
            orderDAL.Add(entity);
        }

        public void Update(Order entity)
        {
            Check(entity);
            orderDAL.Update(entity);
        }


        public void Delete(Order entity)
        {
            entity.IsActive = false;
            orderDAL.Update(entity);
        }

        public void DeleteByID(int entityID)
        {
            Order order = Get(entityID);
            order.IsActive = false;
            orderDAL.Update(order);
        }

        
        public Order Get(int entityID)
        {
            return orderDAL.Get(a => a.ID == entityID&&a.IsActive, a=>a.User);
        }

        public ICollection<Order> GetAll()
        {
            return orderDAL.GetAll();
        }

     
    }
}
