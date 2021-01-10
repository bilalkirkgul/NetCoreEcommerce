using Ecommerce.BLL.Abstract;
using Ecommerce.DAL.Concrete.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.BLL.Concrete.DependencyInjection
{
   public static class EFContextBLL
    {
        public static void AddScopeBLL(this IServiceCollection services)
        {
            services.AddScopeDAL();//Bll işlemi startupda çağrıldıgında dal'da otomatik newlenecek
            services.AddScoped<IBrandBLL, BrandService>();
            services.AddScoped<ICategoryBLL, CategoryService>();
            services.AddScoped<IOrderBLL, OrderService>();
            services.AddScoped<IProductBLL, ProductService>();
            services.AddScoped<ISupplierBLL, SupplierService>();
            services.AddScoped<IUserBLL, UserService>();
        }

    }
}
