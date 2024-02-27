
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess1.Abstracts;
using Entities1.Concretes;

namespace DataAccess1.Concretes
{
    public class InstructorsDal : IInstructorsDal
    {
        List<Instructors> _instructors;

        public InstructorsDal()
        {
            _instructors = new List<Instructors>()
            {
                new Instructors() { InstructorId = 1, FullName = "Engin Demiroğ" },
                new Instructors(){InstructorId = 2, FullName = "Süleyman ÖZKAN" }
            };
        }

        public void Add(Instructors instructor)
        {
            _instructors.Add(instructor);
            Console.WriteLine($"{instructor.FullName} DataBase Eğitmen Eklendi!");
        }


        public void Delete(Instructors instructor)
        {
            Instructors instructorsDelete = _instructors.SingleOrDefault(ins => ins.InstructorId == instructor.InstructorId);
            _instructors.Remove(instructorsDelete);
            Console.WriteLine($"{instructor.FullName} DataBase Eğitmen Silindi!");
        }

        public List<Instructors> GetAll()
        {

            return _instructors;

        }

        public List<Instructors> GetId(Instructors Id)
        {
            return _instructors.Where(ins => ins.InstructorId == ins.InstructorId).ToList();
        }

        public void Update(Instructors instructor)
        {
            Instructors instructorsUpdate = _instructors.SingleOrDefault(ins => ins.InstructorId == instructor.InstructorId);
            instructorsUpdate.FullName = instructor.FullName;
            Console.WriteLine("DataBase Eğitmen Güncellendi!");
        }
    }
}
