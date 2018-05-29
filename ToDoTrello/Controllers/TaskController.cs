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
            List<Task> tasks = db.TaskDb.Get().Where(x=>x.User.Email == User.Identity.Name).ToList();
            if (tasks.Count != 0)
            {
                foreach (var task in tasks)
                {
                    task.Priority = db.PriorityDb.Get(x => x.PriorityId == task.PriorityId).FirstOrDefault();
                    task.User = db.UserDb.Get(x => x.UserId == task.UserId).FirstOrDefault();
                }
                ViewBag.Count = "notnull";
            }
            else
            {
                ViewBag.Count = "";
            }
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