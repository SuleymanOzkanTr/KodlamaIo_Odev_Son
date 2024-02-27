using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class InstructorsDal : ICrudDal<Instructors>
    {

        public void Add(Instructors instructor)
        {
            Console.WriteLine("DataBase Eğitmen Eklendi!");
        }


        public void Delete(Instructors instructor)
        {
            Console.WriteLine("DataBase Eğitmen Silindi!");
        }

        public List<Instructors> GetAllList(Instructors instructor)
        {
            return null;
            Console.WriteLine("DataBase Eğitmenler Listelendi.");
        }

        public void GetID(Instructors instructor)
        {
            Console.WriteLine("DataBase Eğitmen Listelendi.");
        }

        public void Update(Instructors instructor)
        {
            Console.WriteLine("DataBase Eğitmen Güncellendi!");
        }
    }
}
