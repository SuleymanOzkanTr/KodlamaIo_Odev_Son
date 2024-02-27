using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DataAccess1.Abstracts;
using Entities1.Concretes;


namespace DataAccess1.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        private List<Categories> _categories;

        public CategoryDal()
        {
            _categories = new List<Categories>()
            {
                new Categories() {CategoryId = 1, Name ="Programalama"},
                new Categories() {CategoryId = 1, Name ="Tümü"},
            };
        }

        public void Add(Categories category)
        {
            _categories.Add(category);
            Console.WriteLine($"{category.Name} DataBase Kategori Eklendi!");
        }

        public void Delete(Categories categories)
        {
            Categories categoriesDelete = _categories.SingleOrDefault(c => c.CategoryId == categories.CategoryId);
            _categories.Remove(categoriesDelete);
        }

        public List<Categories> GetAll()
        {
            return _categories;
        }

        public List<Categories> GetId(Categories CategoryId)
        {

            return _categories.Where(cat => cat.CategoryId == CategoryId.CategoryId).ToList();
        }

        public void Update(Categories category)
        {
            Categories categoriesUpdate = _categories.SingleOrDefault(cat => cat.CategoryId == category.CategoryId);
            categoriesUpdate.CategoryId = category.CategoryId;
            categoriesUpdate.Name = category.Name;
        }

     
    }
}
