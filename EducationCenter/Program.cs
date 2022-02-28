using EducationCenter.Data.IRepositories;
using EducationCenter.Data.Repositories;
using EducationCenter.Domain.Models;
using System;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EducationCenter
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            IStudentRepository studentRepository = new StudentRepository();
            IGroupRepository groupRepository = new GroupRepository();
            IEmployeeRepository employeeRepository = new EmployeeRepository();   
            ITeacherRepository teacherRepository = new TeacherRepository();

            //await studentRepository.CreateAsync(new Student()
            //{
            //    FirstName = "Malika",
            //    LastName = "Eshmirzayeva",
            //    Gender  = Domain.Enums.Gender.Female
            //});

            //await studentRepository.CreateAsync(new Student()
            //{
            //    FirstName = "Malika",
            //    LastName = "Eshmirzayeva",
            //    Gender = Domain.Enums.Gender.Female
            //});

            //Teacher teacher = teacherRepository.GetAsync(p => p.FirstName == "Sevara").Result;

            //Console.WriteLine(teacher.Id + "." + teacher.FirstName + " " + teacher.LastName + " " + teacher.BirthDate);

            //await studentRepository.CreateAsync(new Student()
            //{
            //    FirstName = "Nilufar",
            //    LastName = "Rashidova",

            //});



            //Teacher teacher = new Teacher()
            //{
            //    FirstName = "Ali",
            //    LastName = "Valiyev",
            //    PhoneNumber = "+998 91 987-65-43",
            //    Gender = Domain.Enums.Gender.Male,
            //    Subject = Domain.Enums.Subject.Java
            //};
            //await teacherRepository.CreateAsync(teacher);

            //Teacher teacher1 = new Teacher()
            //{
            //    FirstName = "Mohinur",
            //    LastName = "Mustafayeva",
            //    PhoneNumber = "+998 90 365-00-45",
            //    Gender = Domain.Enums.Gender.Female,
            //    Subject = Domain.Enums.Subject.Go
            //};

            //await teacherRepository.CreateAsync(teacher1);

            // await teacherRepository.DeleteAsync(p => p.FirstName == "Ali");

            //Teacher teacher = new Teacher()
            //{
            //    Id = 2,
            //    FirstName = "Sevara",
            //    LastName = "Kudratova",
            //    PhoneNumber = "+998 97 452-14-95",
            //    Gender = Domain.Enums.Gender.Male,
            //    Subject = Domain.Enums.Subject.Go
            //};

            //await teacherRepository.UpdateAsync(teacher);

            var teachers = await teacherRepository.GetAllAsync();

            foreach (Teacher teacherr in teachers)
            {
                System.Console.WriteLine(teacherr.Id + "." + teacherr.FirstName + " " + teacherr.LastName + " " + teacherr.Subject);
            }

            //await studentRepository.DeleteAsync(p=>p.Id == 6);

            var students = await studentRepository.GetAllAsync();
            foreach (var student in students)
            {
                Console.WriteLine(student.Id + " " + student.FirstName + " " + student.LastName);
            }


            //Group group = new Group()
            //{
            //    Name = "Bootcamp dotnet #1",
            //    OpenedDate = DateTime.Now
            //};
            //group.Teacher = teacherRepository.GetAsync(p => p.Id == 5).Result;
            //Student student1 = studentRepository.GetAsync(p => p.FirstName == "Nilufar").Result;
            //group.Students.Add(student1);

            ////await groupRepository.CreateAsync(group);
            //var groups = await groupRepository.GetAllAsync();
            //foreach(var group in groups)
            //    Console.WriteLine(group.Id + "." + group.Name);

            var group = await groupRepository.GetAsync(p=>p.Id == 1);
            Console.WriteLine(group.Id + "." + group.Name);

        }
    }
}
