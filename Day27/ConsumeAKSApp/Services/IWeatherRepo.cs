using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumeAKSApp.Services
{
    public interface IWeatherRepo<T>
    {
        Task<ICollection<T>> GetAll();
    }
}
