using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Ecommerce.BLL.Abstract;
using Ecommerce.Model.Entities;
using Ecommerce.UI.CoreMVC.Helper;
using Ecommerce.UI.CoreMVC.Models.Cart;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.UI.CoreMVC.Controllers
{
    public class CartController : Controller
    {
        IUserBLL userBLL;
        IOrderBLL orderBLL;

        public CartController(IUserBLL bLL, IOrderBLL orderbll)
        {
            userBLL = bLL;
            orderBLL = orderbll;

        }

        public IActionResult Index()
        {
            MyCart myCart = HttpContext.Session.Get<MyCart>("cart");
            return View(myCart);
        }

        [HttpPost]
        public IActionResult AddToCart([FromBody] CartVM cart)
        {
            MyCart sepet = HttpContext.Session.Get<MyCart>("cart");
            CartItem cartItem = new CartItem();
            cartItem.ID = cart.ID;
            cartItem.Name = cart.Name;
            cartItem.Price = cart.Price;
            cartItem.ProductImgUrl = cart.ProductImgUrl;
            cartItem.Description = cart.Description;
            cartItem.BrandNane = cart.BrandName;
            cartItem.Amount = 1;
            sepet.AddCart(cartItem);
            HttpContext.Session.Set<MyCart>("cart", sepet);
            return PartialView("_cartButton", sepet.TotalAmount);
        }

        [HttpGet]
        public IActionResult GetOrders()
        {
            MyCart sepet = HttpContext.Session.Get<MyCart>("cart");
            

            if (string.IsNullOrEmpty(User.FindFirstValue(ClaimTypes.UserData)))
            {
                return RedirectToAction("Login", "Account");
            }
            int userID = int.Parse(User.FindFirstValue(ClaimTypes.UserData));
            Order order = new Order();
            order.OrderDetails = new List<OrderDetail>();
            order.UserID = userID;
            order.ShipAddress = userBLL.GetAddres(userID);

            foreach (CartItem item in sepet.GetAllCartItem)
            {
                order.OrderDetails.Add(new OrderDetail() { ProductID = item.ID, Price = item.Price, Quantity = item.Amount });
            }

            
            orderBLL.Insert(order);



            return RedirectToAction("Index", "Home");
        }



        public IActionResult GetCartButton()
        {
            MyCart cart = HttpContext.Session.Get<MyCart>("cart");
            return PartialView("_cartButton", cart.TotalAmount);
        }

        public IActionResult UpdateToCart(short amount, int id)
        {
            MyCart guncellenecekSepet = HttpContext.Session.Get<MyCart>("cart");
            guncellenecekSepet.Update(id, amount);
            HttpContext.Session.Set<MyCart>("cart", guncellenecekSepet);
            return PartialView("_tableListCart", guncellenecekSepet);
        }

        public IActionResult DeleteToCart(int id)
        {
            MyCart silinecekSepet = HttpContext.Session.Get<MyCart>("cart");
            silinecekSepet.Delete(id);
            HttpContext.Session.Set<MyCart>("cart", silinecekSepet);
            return PartialView("_tableListCart", silinecekSepet);
        }

    }
}
