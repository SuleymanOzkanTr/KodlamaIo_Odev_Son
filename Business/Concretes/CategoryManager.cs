using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concretes;

namespace Business.Concretes
{
    public class CategoryManager : ICrudDal<Categories>
    {
        public void Add(Categories category)
        {
            //Business kuralları
        }

        public void Delete(Categories category)
        {
            //Business kuralları
        }

        public List<Categories> GetAllList(Categories category)
        {
            return null;

            //Business kuralları
        }

        public void GetID(Categories category)
        {
            //Business kuralları
        }

        public void Update(Categories category)
        {
            //Business kuralları
        }
    }
}
