using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business1.Abstracts;
using DataAccess1.Abstracts;

using Entities1.Concretes;

namespace Business1.Concretes
{
    public class CourseManager : ICourseServices
    {
        private ICoursesDal _courses;

        public CourseManager(ICoursesDal courses)
        {
            _courses = courses;
        }


        public void Add(Courses course)
        {
            _courses.Add(course);
            //Business kuralları
        }

        public void Delete(Courses Id)
        {
            _courses.Delete(Id);
            //Business kuralları
        }

        public List<Courses> GetAll()
        {
            return _courses.GetAll();
            //Business kuralları
            
        }

        public List<Courses> GetId(Courses courses)
        {
            return _courses.GetId(courses);
            //Business kuralları
        }

        public void Update(Courses course)
        {
            _courses.Update(course);
            //Business kuralları
        }
    }
}
