using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commerce.Repo
{
    public interface IISlem<T>
    {
        IEnumerable<T> GetAll();
        void Save(T entity);
        void Delete(T entity);
        void Update(T entity);
        T Get(int id);
        
    }
}
