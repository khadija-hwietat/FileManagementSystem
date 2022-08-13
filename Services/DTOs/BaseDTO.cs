using System.ComponentModel.DataAnnotations;

namespace Services.Models
{
    public class BaseDTO
    {
        [Key]
        public long Id { get; set; }
        public DateTime CreationDate { get; set; }
        public string Path { get; set; }
    }
}
