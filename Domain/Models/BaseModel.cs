using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class BaseModel
    {
        [Key]
        public long Id { get; set; }
        public DateTime CreationDate { get; set; }
        public string Path { get; set; }
    }
}
