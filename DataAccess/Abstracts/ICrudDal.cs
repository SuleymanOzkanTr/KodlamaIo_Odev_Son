using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface ICrudDal<T>
    {
        List<T> GetAllList(T entity);
        void GetID(T entity);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
