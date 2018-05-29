using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BOL;
using BOL.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http.Features.Authentication;
using Microsoft.AspNetCore.Mvc;
using ToDoTrello.Models;

namespace ToDoTrello.Controllers
{
    public class AccountController : BaseController
    {
        public AccountController(ToDoTrelloContext context) : base(context)
        { }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                User user = db.UserDb.Get().FirstOrDefault(x => x.Email == model.Email && x.Password == model.Password);
                if (user != null)
                {
                    Role role = db.RoleDb.Get().FirstOrDefault(x => x.RoleId == user.RoleId);
                    if (role != null)
                    {
                        user.RoleId = role.RoleId;
                        user.Role = role;
                    }
                    Authenticate(user);
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Login or password are incorrect");
            }

            return View("Login");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                User user = db.UserDb.Get().FirstOrDefault(u => u.Email == model.Email);
                if (user == null)
                {
                    Role role = db.RoleDb.Get().FirstOrDefault(x => x.RoleName == "Blocked");
                    user = new User()
                    {
                        Email = model.Email,
                        Password = model.Password,
                        FirstName = model.FirstName,
                        LastName = model.LastName
                    };
                    if (role != null)
                    {
                        user.RoleId = role.RoleId;
                        user.Role = role;
                    }
                    db.UserDb.Add(user);
                    Authenticate(user);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Login or password are incorrect");
                }
            }
            return View("Login");
        }

        private async void Authenticate(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Email),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role.RoleName)
            };
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }
    }
}