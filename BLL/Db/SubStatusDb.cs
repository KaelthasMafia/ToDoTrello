using System;
using System.Collections.Generic;
using System.Text;
using BOL;
using BOL.Models;
using DAL;
using Microsoft.EntityFrameworkCore;

namespace BLL.Db
{
    public class SubStatusDb
    {
        private readonly IRepository<SubStatus> repository;
        public SubStatusDb(ToDoTrelloContext context)
        {
            repository = new Repository<SubStatus>(new UnitOfWork(context));
        }

        public void Add(SubStatus subStatus)
        {
            repository.Add(subStatus);
        }

        public void Update(SubStatus subStatus)
        {
            repository.Update(subStatus);
        }

        public void Delete(SubStatus subStatus)
        {
            repository.Delete(subStatus);
        }

        public IEnumerable<SubStatus> Get()
        {
            return repository.Get();
        }

        public IEnumerable<SubStatus> Get(System.Linq.Expressions.Expression<Func<SubStatus, bool>> predicate)
        {
            return repository.Get(predicate);
        }
    }
}
