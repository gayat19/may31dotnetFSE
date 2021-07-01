using Microsoft.Extensions.Logging;
using MyPizzaStoreApplication.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MyPizzaStoreApplication.Services
{
    public class PizzaRepo : IRepo<Pizza, int>
    {
        private readonly PizzaContext _context;
        private readonly ILogger<PizzaRepo> _logger;

        public PizzaRepo(PizzaContext context,ILogger<PizzaRepo> logger)
        {
            _context = context;
            _logger = logger;
        }
        public async Task<int> Add(Pizza t)
        {
            //try
            //{
            //    _context.Add(t);
            //    _context.SaveChanges();
            //    return t.Id;
            // }
            //catch (Exception e)
            //{
            //    _logger.LogError("Unable to add pizza " + e.Message);
            //}
            //return -1;

            try
            {
                Pizza pizza = new Pizza();
                using (var httpClient = new HttpClient()) 
                {
                    StringContent content = new StringContent(JsonConvert.SerializeObject(t), Encoding.UTF8, "application/json");
                    using (var response = await httpClient.PostAsync("http://localhost:34661/api/Pizza", content))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            string apiResponse = await response.Content.ReadAsStringAsync();
                            pizza = JsonConvert.DeserializeObject<Pizza>(apiResponse);
                            return pizza.Id;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                _logger.LogError("Unable to retrive pizza from API " + e.Message);
            }
            return -1;
        }

        public async Task<Pizza> Get(int k)
        {
            try
            {
                Pizza pizza = new Pizza();
                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.GetAsync("http://localhost:34661/api/Pizza/" + k)) 
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            string apiResponse = await response.Content.ReadAsStringAsync();
                            pizza = JsonConvert.DeserializeObject<Pizza>(apiResponse);
                            return pizza;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                _logger.LogError("Unable to retrive pizza from API " + e.Message);
            }
            return null;
        }

        public async Task<ICollection<Pizza>> GetAll()
        {
            //return _context.Pizzas.ToList();
            try
            {
                List<Pizza> pizzas = new List<Pizza>();
                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.GetAsync("http://localhost:34661/api/Pizza"))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            string apiResponse = await response.Content.ReadAsStringAsync();
                            pizzas = JsonConvert.DeserializeObject<List<Pizza>>(apiResponse);
                            return pizzas;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                _logger.LogError("Unable to retrive pizza from API " + e.Message);
            }
            return null;
        }

        public async Task<Pizza> Update(int k, Pizza t)
        {
            try
            {
                Pizza pizza = new Pizza();
                using (var httpClient = new HttpClient())
                {
                    StringContent content = new StringContent(JsonConvert.SerializeObject(t), Encoding.UTF8, "application/json");
                    using (var response = await httpClient.PutAsync("http://localhost:34661/api/Pizza/" + k,content))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            string apiResponse = await response.Content.ReadAsStringAsync();
                            pizza = JsonConvert.DeserializeObject<Pizza>(apiResponse);
                            return pizza;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                _logger.LogError("Unable to retrive pizza from API " + e.Message);
            }
            return null;
         }
        public async Task<Pizza> Delete(int k)
        {
            try
            {
                Pizza pizza = new Pizza();
                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.DeleteAsync("http://localhost:34661/api/Pizza/" + k))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            string apiResponse = await response.Content.ReadAsStringAsync();
                            pizza = JsonConvert.DeserializeObject<Pizza>(apiResponse);
                            return pizza;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                _logger.LogError("Unable to retrive pizza from API " + e.Message);
            }
            return null;
        }
    }
}
