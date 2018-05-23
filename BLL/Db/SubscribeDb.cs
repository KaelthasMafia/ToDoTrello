using System;
using System.Collections.Generic;
using System.Text;
using BOL;
using BOL.Models;
using DAL;

namespace BLL.Db
{
    public class SubscribeDb
    {
        private readonly IRepository<Subscribe> repository;
        public SubscribeDb(ToDoTrelloContext context)
        {
            repository = new Repository<Subscribe>(new UnitOfWork(context));
        }

        public void Add(Subscribe subscribe)
        {
            repository.Add(subscribe);
        }

        public void Update(Subscribe subscribe)
        {
            repository.Update(subscribe);
        }

        public void Delete(Subscribe subscribe)
        {
            repository.Delete(subscribe);
        }

        public IEnumerable<Subscribe> Get()
        {
            return repository.Get();
        }

        public IEnumerable<Subscribe> Get(System.Linq.Expressions.Expression<Func<Subscribe, bool>> predicate)
        {
            return repository.Get(predicate);
        }
    }
}
