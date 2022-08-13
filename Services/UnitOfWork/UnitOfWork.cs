
using Domain.Models;
using Repository.Data;
using Repository.Repositories;

namespace Services.UnitOfWork
{
    public class UnitOfWork<Tmodel> : IUnitOfWork<FileManagmentSystemContext, Tmodel> where Tmodel : BaseModel
    {

        public FileManagmentSystemContext Context { get; set; }
        public BaseRepository<FileManagmentSystemContext, Tmodel> BaseRepository { get; set; }

        public UnitOfWork(FileManagmentSystemContext context)
        {
            Context = context;
            BaseRepository = new BaseRepository<FileManagmentSystemContext ,Tmodel>(context);
        }

        public void Dispose()
        {
            Context.Dispose();
        }

        public void Save()
        {
            Context.SaveChanges();
        }
    }
}
