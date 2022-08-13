using Domain.Models;
using Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Interfaces;
using Services.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Services.UnitOfWork;
using Repository.Repositories;

namespace Services
{
    public class BaseSevice<DB, TModel, TData> : IService<DB, TModel, TData> where TModel : BaseModel where TData : BaseDTO where DB : DbContext
    {
        public IRepository<DB , TModel> Repository { get; set; }
        public IMapper Mapper { get; set; }

        public BaseSevice(IRepository<DB, TModel> repository, IMapper mapper )
        {
            Repository = repository;
            Mapper = mapper;

        }

        public IEnumerable<TData> GetAll()
        {
            var model = Repository.GetAll();
            var data = Mapper.Map<IEnumerable<TData>>(model);
            return data;
        }

        public IEnumerable<TData>Find(Expression<Func<TModel, bool>> expression)
        {
            var model = Repository.Find(expression);
            var data = Mapper.Map<IEnumerable<TData>>(model);
            return data;
        }

        public TData GetById(long id)
        {
            var model = Repository.GetById(id);
            var data = Mapper.Map<TData>(model);
            return data;
        }

        public virtual void   Add(TModel entity)
        {
            Repository.Add(entity);
        }

      

        public virtual void Remove(TModel entity)
        {
            Repository.Remove(entity);
        }

  
    }
}
