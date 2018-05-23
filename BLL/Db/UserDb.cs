using System;
using System.Collections.Generic;
using System.Text;
using BOL;
using BOL.Models;
using DAL;

namespace BLL.Db
{
    public class UserDb
    {
        private readonly IRepository<User> repository;
        public UserDb(ToDoTrelloContext context)
        {
            repository = new Repository<User>(new UnitOfWork(context));
        }

        public void Add(User user)
        {
            repository.Add(user);
        }

        public void Update(User user)
        {
            repository.Update(user);
        }

        public void Delete(User user)
        {
            repository.Delete(user);
        }

        public IEnumerable<User> Get()
        {
            return repository.Get();
        }

        public IEnumerable<User> Get(System.Linq.Expressions.Expression<Func<User, bool>> predicate)
        {
            return repository.Get(predicate);
        }
    }
}
