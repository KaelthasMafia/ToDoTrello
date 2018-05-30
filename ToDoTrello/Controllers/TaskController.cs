using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BOL;
using BOL.Models;
using Microsoft.AspNetCore.Mvc;
using Task = BOL.Models.Task;

namespace ToDoTrello.Controllers
{
    public class TaskController : BaseController
    {
        public TaskController(ToDoTrelloContext context) : base(context)
        { }

        [HttpGet]
        public IActionResult TasksList()
        {
            List<Task> tasks = queries.GetTasksForUser(User.Identity.Name);
            return View(tasks);
        }

        [HttpPost]
        public IActionResult DeleteTask(int id)
        {
            return RedirectToAction("TasksList");
        }

        [HttpGet]
        public IActionResult CreateTask()
        {
            return RedirectToAction("TasksList");
        }
    }
}