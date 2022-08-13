using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Repositories;

namespace Services.UnitOfWork
{
    public interface IUnitOfWork<DB ,TModel> : IDisposable where DB : DbContext where TModel : BaseModel
    {
        public BaseRepository<DB, TModel> BaseRepository { get; set; }
        public DB Context { get; set; }
        public void Save();

    }
}
