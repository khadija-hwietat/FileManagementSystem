namespace Domain.Models

{
    public class FolderModel : BaseModel
    {
        public string Name { get; set; }
        public long? ParentId { get; set; }
        public List<FileModel> Files { get; set; }
        public List<FolderModel> SubFolders { get; set; }
    }
}


