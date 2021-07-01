using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPizzaStoreApplication.Services
{
    public interface IRepo<T,K>
    {
        public Task<ICollection<T>> GetAll();
        T Get(K k);
        K Add(T t);
        T Update(K k, T t);

        T Delete(K k);

    }
}
