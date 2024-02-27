using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess1.Abstracts
{
    public interface IEntityDal<T>
    {
        List<T> GetAll();
        List<T> GetId(T entity);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
