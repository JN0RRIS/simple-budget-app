using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBudget.DatabaseAccess
{
    public interface IRepository<T, K>
    {
        List<T> ReadAll();
        T GetById(K id); 
        T Create(T entity); 
        T Update(T entity); 
        T Delete(T entity);
    }
}
