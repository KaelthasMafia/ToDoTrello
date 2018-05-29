using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly UnitOfWork unitOfWork;

        public Repository(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void Add(T entity)
        {
            unitOfWork.Context.Set<T>().Add(entity);
            unitOfWork.Commit();
        }

        public void Delete(T entity)
        {
            T existing = unitOfWork.Context.Set<T>().Find(entity);
            if (existing != null)
            {
                unitOfWork.Context.Set<T>().Remove(existing);
            }
            unitOfWork.Commit();
        }

        public IEnumerable<T> Get()
        {
            return unitOfWork.Context.Set<T>().AsEnumerable<T>();
        }

        public IEnumerable<T> Get(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return unitOfWork.Context.Set<T>().Where(predicate).AsEnumerable<T>();
        }

        public void Update(T entity)
        {
            unitOfWork.Context.Entry(entity).State = EntityState.Modified;
            unitOfWork.Commit();
        }
    }
}
