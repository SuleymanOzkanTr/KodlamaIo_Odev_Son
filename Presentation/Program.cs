using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business1.Concretes;
using DataAccess1.Abstracts;
using DataAccess1.Concretes;
using Entities1.Concretes;

namespace Presentation
{
    public class Program
    {
        static void Main(string[] args)
        {

            CourseManager courseManager = new CourseManager(new CoursesDal());
            Instructors instructors1 = new Instructors();
            instructors1.FullName = "Eda ozkan";
            Courses courses1 = new Courses();
            courses1.Name = "selam";

            InstructorManager instructorManager = new InstructorManager(new InstructorsDal());

            var result =courseManager.GetAll();

            foreach (var item in result)
            {
                Console.WriteLine(item.Name);
            }

            courseManager.Add(courses1);

            Console.WriteLine(courses1.Name);

            instructorManager.Add(instructors1);

            Console.WriteLine(instructors1.FullName);

            Console.ReadLine();

        }
    }
}
