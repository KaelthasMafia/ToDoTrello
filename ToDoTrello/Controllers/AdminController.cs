using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BOL;
using BOL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ToDoTrello.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : BaseController
    {
        public AdminController(ToDoTrelloContext context) : base(context)
        { }

        public IActionResult ViewUserList()
        {
            List<User> users = db.UserDb.Get().ToList();
            foreach (var user in users)
            {
                int roleId = db.UserDb.Get(x => x.UserId == user.UserId).FirstOrDefault().RoleId;
                user.Role = db.RoleDb.Get(x => x.RoleId == roleId).FirstOrDefault();
            }
            return View(users);
        }

        public IActionResult DeleteUser(int id)
        {
            User user = db.UserDb.Get(x => x.UserId == id).FirstOrDefault();
            db.UserDb.Delete(user);
            return View("ViewUserList");
        }

        public IActionResult ActivateUser(int id)
        {
            User user = db.UserDb.Get(x => x.UserId == id).FirstOrDefault();
            user.RoleId = db.RoleDb.Get(x => x.RoleName == "User").FirstOrDefault().RoleId;
            db.UserDb.Update(user);
            return RedirectToAction("ViewUserList");
        }

        public IActionResult BlockUser(int id)
        {
            User user = db.UserDb.Get(x => x.UserId == id).FirstOrDefault();
            int roleId = db.RoleDb.Get(x => x.RoleName == "Blocked").FirstOrDefault().RoleId;
            user.RoleId = roleId;
            db.UserDb.Update(user);
            return RedirectToAction("ViewUserList");
        }
    }
}