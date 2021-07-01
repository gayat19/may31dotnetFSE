using Microsoft.Extensions.Logging;
using MyPizzaStoreApplication.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
        public int Add(Pizza t)
        {
            try
            {
                _context.Add(t);
                _context.SaveChanges();
                return t.Id;
             }
            catch (Exception e)
            {
                _logger.LogError("Unable to add pizza " + e.Message);
            }
            return -1;
        }

        public Pizza Get(int k)
        {
            try
            {
                var pizza = _context.Pizzas.Single(p => p.Id == k);
                return pizza;
            }
            catch (Exception e)
            {
                _logger.LogError("No pizza with this id "+k+" " + e.Message);
            }
            return null ;
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

        public Pizza Update(int k, Pizza t)
        {
            try
            {
                var pizza = Get(k);
                _context.Update(t);
                _context.SaveChanges();
                return pizza;
            }
            catch (Exception e)
            {
                _logger.LogError("Unable to update the pizza details" + k + " " + e.Message);
            }
            return null;
        }
        public Pizza Delete(int k)
        {
            try
            {
                var pizza = Get(k);
                _context.Pizzas.Remove(pizza);
                _context.SaveChanges();
                return pizza;
            }
            catch (Exception e)
            {
                _logger.LogError("Unable to delete the pizza details" + k + " " + e.Message);
            }
            return null;
        }
    }
}
