using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Ecommerce.BLL.Abstract;
using Ecommerce.Model.Entities;
using Ecommerce.Model.Enums;
using Ecommerce.UI.CoreMVC.Helper;
using Ecommerce.UI.CoreMVC.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.UI.CoreMVC.Controllers
{
    public class AccountController : Controller
    {
        IUserBLL userBLL;
        public AccountController(IUserBLL user)
        {
            userBLL = user;
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]//formda veriyi post ederken güvenliğin sağlanması için bu kullanılıyor..
        public IActionResult Login(LoginVM login)
        {
            User loginUser = userBLL.GetUserByLoginData(login.Email, login.Password);
            if (loginUser != null)
            {
                List<Claim> claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name,loginUser.Email),
                    new Claim(ClaimTypes.Role,loginUser.Role.ToString()),
                      new Claim(ClaimTypes.UserData,loginUser.ID.ToString()),
                    new Claim(ClaimTypes.NameIdentifier,loginUser.FirstName)
                };

                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

                if (loginUser.Role == UserRole.User)
                {
                    return RedirectToAction("Index", "Home");
                }
                else if (loginUser.Role == UserRole.Admin)
                {

                    return RedirectToAction("Index", "Home", new { area = "Admin" });
                }
                else
                {
                    return View();
                }
            }
            else
            {
                ViewBag.Message = "Kullanıcı bilgilerinizi kontrol edin";
                return View();
            }

        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]//formda veriyi post ederken güvenliğin sağlanması için bu kullanılıyor..
        public IActionResult Register(UserVM userVM)
        {
            try
            {
                User user = new User();
                user.ID = userVM.UserID;
                user.Email = userVM.Email;
                user.Password = userVM.Password;
                user.FirstName = userVM.FirstName;
                user.LastName = userVM.LastName;
                user.BirthDate = userVM.BirthDate;
                user.Address = userVM.Address;
                userBLL.Insert(user);
                bool check = MailHelper.SendActivationCode(user.FirstName, user.Email, user.ActivationCode);
                if (check)
                {
                    ViewBag.Message = $"{user.Email} adresinin mail kutusunu (spam) kontrol ediniz";
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.Message = "Aktivasyon Maili Gönderilemedi. Bilgilerinizi kontrol edin";
                    return RedirectToAction("Login", "Account");
                }

            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return RedirectToAction("Login", "Account");
            }

        }


        public IActionResult ActivationUser(Guid id)
        {
            User newUser = userBLL.GetUserByActivationCode(id);
            if (newUser != null)
            {
                newUser.IsActive = true;
                userBLL.Update(newUser);
                return RedirectToAction("Login");
            }
            else
            {
                ViewBag.Message = "Aktif edilecek kullanıcı bulunamamamıştır";
                return View();
            }

        }

        public IActionResult LoginName()
        {
            string name = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return PartialView("_loginModel", name);
        }

        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }


    }
}
