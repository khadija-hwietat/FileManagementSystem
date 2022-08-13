using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Data;

namespace Repository.Repositories
{
    public class FileRepository : BaseRepository<FileManagmentSystemContext , FileModel>
    {
        public FileRepository(FileManagmentSystemContext context) : base(context)
        {
        }
    }
}
