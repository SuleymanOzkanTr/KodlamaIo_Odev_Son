
using Business1.Abstracts;
using DataAccess1.Abstracts;
using Entities1.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business1.Concretes
{
    public class CategoryManager : ICategoryServices
    {
        private ICategoryDal _category;

        public CategoryManager(ICategoryDal category)
        {
            _category = category;
        }

        public void Add(Categories entity)
        {
            _category.Add(entity);
        }

        public void Delete(Categories Id)
        {
            _category.Delete(Id);
        }

        public List<Categories> GetAll()
        {
            return _category.GetAll();
        }

        public List<Categories> GetId(Categories ID)
        {
            return _category.GetId(ID);
        }

        public void Update(Categories entity)
        {
            _category.Update(entity);
        }
    }
}
