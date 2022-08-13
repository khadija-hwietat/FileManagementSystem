namespace Services.Models

{
    public class FolderDTO : BaseDTO
    {
        public string Name { get; set; }
        public long? ParentId { get; set; }
        public List<FileDTO> Files { get; set; }
        public List<FolderDTO> SubFolders { get; set; }
    }
}


