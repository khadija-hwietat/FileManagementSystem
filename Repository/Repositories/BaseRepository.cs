using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Repository.Repositories
{
    public class BaseRepository<DB , T>  : IRepository<DB, T> where T : BaseModel where DB : DbContext
    {
        public  DB Context { get; set; }

        public BaseRepository(DB context)
        {
            this.Context = context;
        }
        public void Add(T entity)
        {
            Context.Set<T>().Add(entity);
        }
        public void AddRange(IEnumerable<T> entities)
        {
            Context.Set<T>().AddRange(entities);
        }
        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return Context.Set<T>().Where(expression);
        }
        public IEnumerable<T> GetAll()
        {
            return Context.Set<T>().ToList();
        }
        public T GetById(long id)
        {
            return Context.Set<T>().Find(id);
        }
        public void Remove(T entity)
        {
            Context.Set<T>().Remove(entity);
        }
        public void RemoveRange(IEnumerable<T> entities)
        {
            Context.Set<T>().RemoveRange(entities);
        }
    }
}
