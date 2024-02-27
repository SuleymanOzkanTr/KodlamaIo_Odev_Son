using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class CourseManager : ICrudDal<Courses>
    {
        ICrudDal<Courses> _iCrudDal;

        public void Add(Courses course)
        {
            //Business kuralları
        }

        public void Delete(Courses course)
        {
            //Business kuralları
        }

        public List<Courses> GetAllList(Courses course)
        {
            //Business kuralları
            return null;
        }

        public void GetID(Courses course)
        {
            //Business kuralları
        }

        public void Update(Courses course)
        {
            //Business kuralları
        }
    }
}
