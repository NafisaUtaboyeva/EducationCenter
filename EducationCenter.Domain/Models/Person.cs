using EducationCenter.Domain.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace EducationCenter.Domain.Models
{
    public abstract class Person : BaseEntity
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public Gender Gender { get; set; }
    }
}
