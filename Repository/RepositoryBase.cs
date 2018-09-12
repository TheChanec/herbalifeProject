using Example1.Contracts;
using Example1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Example1.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected RepositoryContext RepositoryContext { get; set; }

        public RepositoryBase(RepositoryContext repositoryContext)
        {
            this.RepositoryContext = repositoryContext;
        }

        public void Create(T entity)
        {
            RepositoryContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            RepositoryContext.Set<T>().Remove(entity);
        }

        public IEnumerable<T> FindAll()
        {
            return RepositoryContext.Set<T>();
        }

        public IEnumerable<T> FindByCondition(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            return RepositoryContext.Set<T>().Where(expression);
        }

        public void Save()
        {
            RepositoryContext.SaveChanges();
        }

        public void Update(T entity)
        {
            RepositoryContext.Set<T>().Update(entity);
        }
    }
}
