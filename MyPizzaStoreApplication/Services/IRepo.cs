using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPizzaStoreApplication.Services
{
    public interface IRepo<T,K>
    {
        ICollection<T> GetAll();
        T Get(K k);
        K Add(T t);

    }
}
