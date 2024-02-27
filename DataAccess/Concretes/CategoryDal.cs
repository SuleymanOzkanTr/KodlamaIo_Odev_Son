using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstracts;


namespace DataAccess.Concretes
{
    public class CategoryDal : ICrudDal<Categories>
    {
        public void Add(Categories category)
        {
            Console.WriteLine("DataBase Kategori Eklendi!");
        }

        public void Delete(Categories category)
        {
            Console.WriteLine("DataBase Kategori Silindi!");
        }

        public List<Categories> GetAllList(Categories category)
        {
            return null;
            Console.WriteLine("DataBase Kategoriler Getirildi!");
        }

        public void GetID(Categories category)
        {
            Console.WriteLine("DataBase Kategori Listelendi!");
        }

        public void Update(Categories category)
        {
            Console.WriteLine("DataBase Kategori Güncellendi!");
        }

     
    }
}
