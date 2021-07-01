using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPizzaStoreApplication.Services
{
    public interface IRepo<T,K>
    {
        public Task<ICollection<T>> GetAll();
        Task<T> Get(K k);
        Task<K> Add(T t);
        Task<T> Update(K k, T t);

        Task<T> Delete(K k);

    }
}
