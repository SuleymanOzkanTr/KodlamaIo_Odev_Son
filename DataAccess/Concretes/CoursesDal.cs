using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class CoursesDal : ICrudDal<Courses>
    {
       
        public void Add(Courses course)
        {
            Console.WriteLine("DataBase Ders Eklendi!");
        }

        public void Delete(Courses course)
        {
            Console.WriteLine("DataBase Ders Silindi!");
        }

        public List<Courses> GetAllList(Courses course)
        {
            return null;
            Console.WriteLine("DataBase Dersler Listelendi");
        }

        public void GetID(Courses course)
        {
            Console.WriteLine("DataBase Ders Listelendi!");
        }

        public void Update(Courses course)
        {
            Console.WriteLine("DataBase Ders Güncellendi!");
        }
    }
}
