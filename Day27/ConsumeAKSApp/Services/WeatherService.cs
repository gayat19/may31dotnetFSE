using ConsumeAKSApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsumeAKSApp.Services
{
    public class WeatherService : IWeatherRepo<Weather>
    {
        public async Task<ICollection<Weather>> GetAll()
        {
            List<Weather> weathers = new List<Weather>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://52.188.181.58/WeatherForecast"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        weathers = JsonConvert.DeserializeObject<List<Weather>>(apiResponse);
                        return weathers;
                    }
                }
            }
            return null;
        }
    }
}
