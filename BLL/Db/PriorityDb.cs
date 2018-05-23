using System;
using System.Collections.Generic;
using System.Text;
using BOL;
using BOL.Models;
using DAL;

namespace BLL.Db
{
    public class PriorityDb
    {
        private readonly IRepository<Priority> repository;
        public PriorityDb(ToDoTrelloContext context)
        {
            repository = new Repository<Priority>(new UnitOfWork(context));
        }

        public void Add(Priority priority)
        {
            repository.Add(priority);
        }

        public void Update(Priority priority)
        {
            repository.Update(priority);
        }

        public void Delete(Priority priority)
        {
            repository.Delete(priority);
        }

        public IEnumerable<Priority> Get()
        {
            return repository.Get();
        }

        public IEnumerable<Priority> Get(System.Linq.Expressions.Expression<Func<Priority, bool>> predicate)
        {
            return repository.Get(predicate);
        }
    }
}
