using System;
using System.Collections.ObjectModel;

namespace EducationCenter.Domain.Models
{
    public class Group : BaseEntity
    {
        public string Name { get; set; }
        public DateTime OpenedDate { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Collection<Student> Students { get; set; }
        public Group()
        {
            Students = new Collection<Student>();
        }
    }
}
