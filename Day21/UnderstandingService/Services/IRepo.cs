using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnderstandingService.Services
{
    public interface IRepo<T,K>
    {
        public bool Add(T t);
        public ICollection<T> GetAll();
        public T Get(K k);
        public bool Edit(K k, T t);
        public bool Delete(K k);
    }
}
