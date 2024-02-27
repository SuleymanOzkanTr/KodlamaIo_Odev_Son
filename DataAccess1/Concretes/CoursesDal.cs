
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using DataAccess1.Abstracts;
using Entities1.Concretes;

namespace DataAccess1.Concretes
{
    public class CoursesDal : ICoursesDal
    {
        private readonly List<Courses> _courses;

        public CoursesDal()
        {
            _courses = new List<Courses>()
            {
                new Courses() { CourseId = 1, Desciption = "Yazılım Geliştirme", Name = "C#", Progressrate = default, StatusFree = true },
                new Courses() { CourseId = 2, Desciption = "Yazılım Geliştirme 2", Name = "Java", Progressrate = default, StatusFree = true }
            };
        }

        public void Add(Courses course)
        {
            _courses.Add(course);
        }

        public void Delete(Courses course)
        {
            Courses coursesToDelete = _courses.SingleOrDefault(co => co.CourseId == course.CourseId);
            _courses.Remove(coursesToDelete);
        }

        public List<Courses> GetAll()
        {
            return _courses;

        }

        public List<Courses> GetId(Courses course)
        {
            return _courses.Where(co => co.CourseId == course.CourseId).ToList();
        }

        public void Update(Courses course)
        {
            Courses courseToUpdate = _courses.SingleOrDefault(co => co.CourseId == course.CourseId);
            courseToUpdate.CourseId = course.CourseId;
            courseToUpdate.Name=course.Name;
            courseToUpdate.Progressrate = course.Progressrate;
            courseToUpdate.StatusFree = course.StatusFree;
            courseToUpdate.Desciption=course.Desciption;
        }
    }
}
