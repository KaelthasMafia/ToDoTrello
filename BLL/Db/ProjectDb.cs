using System;
using System.Collections.Generic;
using System.Text;
using BOL;
using BOL.Models;
using DAL;

namespace BLL.Db
{
    public class ProjectDb
    {
        private readonly IRepository<Project> repository;
        public ProjectDb(ToDoTrelloContext context)
        {
            repository = new Repository<Project>(new UnitOfWork(context));
        }

        public void Add(Project project)
        {
            repository.Add(project);
        }

        public void Update(Project project)
        {
            repository.Update(project);
        }

        public void Delete(Project project)
        {
            repository.Delete(project);
        }

        public IEnumerable<Project> Get()
        {
            return repository.Get();
        }

        public IEnumerable<Project> Get(System.Linq.Expressions.Expression<Func<Project, bool>> predicate)
        {
            return repository.Get(predicate);
        }
    }
}
