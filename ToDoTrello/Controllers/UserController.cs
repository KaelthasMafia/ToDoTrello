using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BOL;
using BOL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ToDoTrello.Controllers
{
    public class UserController : BaseController
    {
        public UserController(ToDoTrelloContext context) : base(context)
        { }

        [HttpGet]
        public IActionResult ViewProfile()
        {
            User user = db.UserDb.Get(x => x.Email == User.Identity.Name).FirstOrDefault();
            var roles = db.RoleDb.Get();
            List<string> roleNames = new List<String>();
            foreach (var role in roles)
            {
                roleNames.Add(role.RoleName);
            }
            SelectList selectRoleNames = new SelectList(roleNames);
            ViewBag.RoleName = selectRoleNames;
            return View(user);
        }
    }
}