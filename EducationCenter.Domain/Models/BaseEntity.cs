using System.ComponentModel.DataAnnotations;

namespace EducationCenter.Domain.Models
{
    public abstract class BaseEntity
    {
        [Required]
        public int Id { get; set; }
    }
}
