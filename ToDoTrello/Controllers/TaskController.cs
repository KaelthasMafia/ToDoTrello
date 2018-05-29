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
                    int priorityId = db.TaskDb.Get(x => x.TaskId == task.TaskId).FirstOrDefault().TaskId;
                    task.Priority = db.PriorityDb.Get(x => x.PriorityId == priorityId).FirstOrDefault();
                }

                ViewBag.Count = "";
            }
            ViewBag.Count = "notnull";
            return View();
        }

        [HttpPost]
        public IActionResult DeleteTask(int id)
        {
            return RedirectToAction("TasksList");
        }

        [HttpGet]
        public IActionResult CreateTask()
        {
            return View();
        }
    }
}