using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCenter.Domain.Models
{
    public class Student : Person
    {
        public Group Group { get; }
    }
}
