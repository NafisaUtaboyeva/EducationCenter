using EducationCenter.Domain.Enums;
using System;

namespace EducationCenter.Domain.Models
{
    public class Employee : Person
    {
        public int Experience { get; set; }
        public DateTime StatedDate { get; set; }
        public string CardNumber { get; set; }
        public Department Department { get; set; }
    }
}
