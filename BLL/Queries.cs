using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLL.Db;
using BOL;
using BOL.Models;

namespace BLL
{
    public class Queries
    {
        private AllDb db;
        public Queries(ToDoTrelloContext context)
        {
            db = new AllDb(context);
        }
        public List<Task> GetTasksForUser(string email)
        {
            User user = db.UserDb.Get(x => x.Email == email).FirstOrDefault();
            List<Work> works = db.WorkDb.Get(x=>x.UserId == user.UserId).ToList();
            List<Task> tasks = new List<Task>();
            foreach (var work in works)
            {
                Task task = db.TaskDb.Get(x => x.TaskId == work.TaskId).FirstOrDefault();
                task.Priority = db.PriorityDb.Get(x => x.PriorityId == task.PriorityId).FirstOrDefault();
                tasks.Add(task);
            }
            return tasks;
        }
    }
}
