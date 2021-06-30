using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaWebService.Services
{
    public interface IRepo<T, K>
    {
        ICollection<T> GetAll();
        T Get(K k);
        K Add(T t);
        T Update(K k, T t);

        T Delete(K k);
    }
}
