using System;
using System.Collections.Generic;
using System.Text;
using BOL;
using BOL.Models;
using DAL;
using Microsoft.EntityFrameworkCore;

namespace BLL.Db
{
    public class TaskDb
    {
        private readonly IRepository<Task> repository;
        public TaskDb(ToDoTrelloContext context)
        {
            repository = new Repository<Task>(new UnitOfWork(context));
        }

        public void Add(Task task)
        {
            repository.Add(task);
        }

        public void Update(Task task)
        {
            repository.Update(task);
        }

        public void Delete(Task task)
        {
            repository.Delete(task);
        }

        public IEnumerable<Task> Get()
        {
            return repository.Get();
        }

        public IEnumerable<Task> Get(System.Linq.Expressions.Expression<Func<Task, bool>> predicate)
        {
            return repository.Get(predicate);
        }
    }
}
