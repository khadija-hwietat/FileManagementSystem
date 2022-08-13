using AutoMapper;
using Domain.Models;
using Services.Models;

namespace Services.MappingConfigurations
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<FolderModel, FolderDTO>();
            CreateMap<FileModel, FileDTO>();

        }
    }
}
