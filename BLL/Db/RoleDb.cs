using System;
using System.Collections.Generic;
using System.Text;
using BOL;
using BOL.Models;
using DAL;

namespace BLL.Db
{
    public class RoleDb
    {
        private readonly IRepository<Role> repository;
        public RoleDb(ToDoTrelloContext context)
        {
            repository = new Repository<Role>(new UnitOfWork(context));
        }

        public void Add(Role role)
        {
            repository.Add(role);
        }

        public void Update(Role role)
        {
            repository.Update(role);
        }

        public void Delete(Role role)
        {
            repository.Delete(role);
        }

        public IEnumerable<Role> Get()
        {
            return repository.Get();
        }

        public IEnumerable<Role> Get(System.Linq.Expressions.Expression<Func<Role, bool>> predicate)
        {
            return repository.Get(predicate);
        }
    }
}
