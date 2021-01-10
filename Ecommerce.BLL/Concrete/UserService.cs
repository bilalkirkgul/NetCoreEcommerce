using Ecommerce.BLL.Abstract;
using Ecommerce.DAL.Abstract;
using Ecommerce.Model.Entities;
using Ecommerce.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.BLL.Concrete
{
    class UserService : IUserBLL
    {
        IUserDAL userDAL;
        public UserService(IUserDAL dal)
        {
            userDAL = dal;
        }

        void Check(User user)
        {
            if (string.IsNullOrEmpty(user.Email) || string.IsNullOrEmpty(user.Password) || string.IsNullOrEmpty(user.FirstName) || string.IsNullOrEmpty(user.LastName) || string.IsNullOrEmpty(user.Address)||string.IsNullOrEmpty(user.BirthDate.ToShortDateString()))
            {
                throw new Exception("(Email, Şifre, İsim, Soyisim, Adres, Doğum Tarihi) boş geçilemez");
            }

            if (user.BirthDate.AddYears(18)>DateTime.Now)
            {
                throw new Exception("Üye 18 yaşından küçük olamaz");
            }
            if (!user.Email.Contains('@')||!user.Email.EndsWith(".com"))
            {
                throw new Exception("hatalı mail adresi, Mail adresinizde ('@') ve ('.com') ibareleri bulunmalıdır");
            }
        }

        public void Insert(User entity)
        {
            Check(entity);
            entity.Role = UserRole.User;
            entity.ActivationCode = Guid.NewGuid();
            userDAL.Add(entity);
        }

        public void Update(User entity)
        {
            Check(entity);
            userDAL.Update(entity);
        }
        public void Delete(User entity)
        {
            entity.IsActive = false;
            userDAL.Update(entity);
        }

        public void DeleteByID(int entityID)
        {
            User user = Get(entityID);
            user.IsActive = false;
            userDAL.Update(user);
        }

        public User Get(int entityID)
        {
            return userDAL.Get(a => a.ID == entityID);
        }

        public ICollection<User> GetAll()
        {
            return userDAL.GetAll();
        }

        public User GetUserByActivationCode(Guid guid)
        {
            User newUser = userDAL.Get(a => a.ActivationCode == guid);
            return newUser;
        }

        public User GetUserByLoginData(string mail, string password)
        {
            User loginUser = userDAL.Get(a => a.Email == mail && a.Password == password && a.IsActive, a => a.Orders);
            return loginUser;
        }

        public string GetAddres(int id)
        {
           User user = userDAL.Get(a => a.ID == id);
            return user.Address;
        }

    }
}
