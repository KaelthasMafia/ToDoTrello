using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BLL.Db;
using BOL;
using BOL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoTrello.Models;

namespace ToDoTrello.Controllers
{
    public class HomeController : Controller
    {
        //private SubStatusDb db;
        public HomeController(ToDoTrelloContext context)
        {
            //db = new SubStatusDb(context);
        }
        public IActionResult Index()
        {
            //db.Add(new SubStatus(){SubStatusName = "To Do"});
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
