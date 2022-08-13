
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository.Data
{
    public class FileManagmentSystemContext : DbContext
    {
        public FileManagmentSystemContext (DbContextOptions<FileManagmentSystemContext> options)
            : base(options)
        {
        }

        public DbSet<FolderModel> FolderModel { get; set; } = default!;

        public DbSet<FileModel>? FileModel { get; set; }
    }
}
