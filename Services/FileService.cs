using AutoMapper;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Data;
using Repository.Repositories;
using Services.Interfaces;
using Services.Models;
using Services.UnitOfWork;

namespace Services
{
    public class FileService : BaseSevice<FileManagmentSystemContext, FileModel, FileDTO>
    {
        public FileService(IRepository<FileManagmentSystemContext, FileModel> repository, IMapper mapper) : base(repository, mapper)
        {
        }
        public override void Add(FileModel fileModel)
        {
            string path1 = @"D:\MyCode\FileManagmentSystem\FileManagmentSystem\Directory";
            string path2 = Path.Combine(path1, fileModel.Name + fileModel.Id + fileModel.Extention);
            try
            {

                if (!System.IO.File.Exists(path2))
                {
                    using (System.IO.FileStream fs = System.IO.File.Create(path2))
                    {
                        for (byte i = 0; i < 100; i++)
                        {
                            fs.WriteByte(i);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            base.Add(fileModel);
            fileModel.Path = path2;
            //TODO: build this function 
           // base.Update(fileModel);

        }

    }
}
