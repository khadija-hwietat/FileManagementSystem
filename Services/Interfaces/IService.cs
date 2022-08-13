using AutoMapper;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Services.Models;
using System.Linq.Expressions;

namespace Services.Interfaces
{
    public interface IService<DB , TModel, TData> where DB : DbContext where TModel : BaseModel where TData : BaseDTO
    {
        public  IEnumerable<TData> GetAll();
      public  IEnumerable<TData> Find(Expression<Func<TModel, bool>> expression);
        public TData GetById(long id);

        public virtual void Add(TModel entity) { }
       public virtual  void Remove(TModel entity) { }
    }
}

