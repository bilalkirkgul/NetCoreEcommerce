using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.BLL.Concrete.DependencyInjection;
using Ecommerce.UI.CoreMVC.Models.Cart;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Ecommerce.UI.CoreMVC.Helper;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace Ecommerce.UI.CoreMVC
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddScopeBLL();//Bll referans verildi.iki taraf içinde nesneleri ayaða kaldýrmak için aldýk.
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromSeconds(30);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;


            });
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(a => a.LoginPath = new PathString("/Account/Login"));
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSession();
            app.Use((HttpContext, nextMiddleware) =>
            {
                HttpContext.Session.Set<MyCart>("cart", new MyCart());
                return nextMiddleware();

            });


            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            


            app.UseEndpoints(endpoints =>
            {

                endpoints.MapControllerRoute(
                    name: "area",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                    );


                endpoints.MapControllerRoute(
                   name: "default",
                   pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
