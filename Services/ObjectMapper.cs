using AutoMapper;
using Domain.Models;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class ObjectMapper<TModel, TData>
    where TModel :  BaseModel
    where TData : BaseDTO
    {
        private static readonly MapperConfiguration _mapperConfiguration;
        public static IMapper Mapper => new Mapper(_mapperConfiguration);

        static ObjectMapper()
        {
            _mapperConfiguration ??= CreateMap();
        }

        private static MapperConfiguration CreateMap()
        {
            return new(cfg =>
            {
                cfg.CreateMap<TModel ,TData >();
            });
        }
    }
}
