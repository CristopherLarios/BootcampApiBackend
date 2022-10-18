using System.ComponentModel.DataAnnotations;
namespace TareaBootcamp.Model.DataModels
{
    public class BaseEntity
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string UpdateBy { get; set; } = string.Empty;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; } = string.Empty;
        public bool IsDeleted { get; set; } = false;

    }
}
