using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business1.Abstracts;
using DataAccess1.Abstracts;
using DataAccess1.Concretes;
using Entities1.Concretes;

namespace Business1.Concretes
{
    public class InstructorManager : IInstructorServices
    {
        private IInstructorsDal _instructors;

        public InstructorManager(IInstructorsDal instructors)
        {
            _instructors = instructors;
        }

        public void Add(Instructors instructor)
        {
            _instructors.Add(instructor); //Business kuralları
        }

        public void Delete(Instructors id)
        {
            _instructors.Delete(id);
            //Business kuralları
        }

        public List<Instructors> GetAll()
        {
            return _instructors.GetAll();
            //Business kuralları

        }

        public List<Instructors> GetId(Instructors id)
        {
            return _instructors.GetId(id);
        }

        public void Update(Instructors Instructor)
        {
            _instructors.Update(Instructor);
            //Business kuralları
        }
    }
}
