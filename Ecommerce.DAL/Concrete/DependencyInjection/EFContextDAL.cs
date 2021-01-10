using Ecommerce.DAL.Abstract;
using Ecommerce.DAL.Concrete.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.DAL.Concrete.DependencyInjection
{
   public static class EFContextDAL//Extensions method static yapıldı
    {

        public static void AddScopeDAL(this IServiceCollection services) //this yazılması gerekiyor import gerçekleştiriyoruz
        {
            services.AddScoped<IBrandDAL, BrandRepository>(); //çağrıldığında ayağa kaldırdım..
            services.AddScoped<ICategoryDAL, CategoryRepository>();
            services.AddScoped<IOrderDAL, OrderRepository>();
            services.AddScoped<IProductDAL, ProductRepository>();
            services.AddScoped<ISupplierDAL, SupplierRepository>();
            services.AddScoped<IUserDAL, UserRepository>();
        }


    }
}
