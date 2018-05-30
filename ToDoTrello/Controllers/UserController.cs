using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BOL;
using BOL.Models;
using Microsoft.AspNetCore.Mvc;

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
            return View(user);
        }
    }
}