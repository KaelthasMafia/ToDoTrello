using System;
using System.Collections.Generic;
using System.Text;
using BOL;
using BOL.Models;
using DAL;

namespace BLL.Db
{
    public class WorkDb
    {
        private readonly IRepository<Work> repository;
        public WorkDb(ToDoTrelloContext context)
        {
            repository = new Repository<Work>(new UnitOfWork(context));
        }

        public void Add(Work work)
        {
            repository.Add(work);
        }

        public void Update(Work work)
        {
            repository.Update(work);
        }

        public void Delete(Work work)
        {
            repository.Delete(work);
        }

        public IEnumerable<Work> Get()
        {
            return repository.Get();
        }

        public IEnumerable<Work> Get(System.Linq.Expressions.Expression<Func<Work, bool>> predicate)
        {
            return repository.Get(predicate);
        }
    }
}
