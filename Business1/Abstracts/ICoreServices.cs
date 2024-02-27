using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business1.Abstracts
{
    public interface ICoreServices<T>
    {
        void Add(T entity);
        void Delete(T Id);
        void Update(T entity);
        List<T> GetAll();
        List<T> GetId(T entity);
    }
}
