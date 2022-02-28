using EducationCenter.Domain.Enums;
using System.Collections.Generic;

namespace EducationCenter.Domain.Models
{
    public class Teacher : Person
    {
        public Subject Subject { get; set; }
        public ICollection<Group> Groups { get; }
        public Teacher()
        {
            Groups = new List<Group>();
        }
    }
}
