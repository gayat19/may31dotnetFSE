﻿using Microsoft.Extensions.Logging;
using MyPizzaStoreApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public ICollection<Pizza> GetAll()
        {
            return _context.Pizzas.ToList();
        }
    }
}
