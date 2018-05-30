using System;
using System.Collections.Generic;
using System.Text;
using BOL;
using BOL.Models;
using DAL;

namespace BLL.Db
{
    public class StageDb
    {
        private readonly IRepository<Stage> repository;
        public StageDb(ToDoTrelloContext context)
        {
            repository = new Repository<Stage>(new UnitOfWork(context));
        }

        public void Add(Stage stage)
        {
            repository.Add(stage);
        }

        public void Update(Stage stage)
        {
            repository.Update(stage);
        }

        public void Delete(Stage stage)
        {
            repository.Delete(stage);
        }

        public IEnumerable<Stage> Get()
        {
            return repository.Get();
        }

        public IEnumerable<Stage> Get(System.Linq.Expressions.Expression<Func<Stage, bool>> predicate)
        {
            return repository.Get(predicate);
        }
    }
}
