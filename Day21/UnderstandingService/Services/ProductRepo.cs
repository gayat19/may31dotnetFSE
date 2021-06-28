
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnderstandingService.Models;

namespace UnderstandingService.Services
{
    public class ProductRepo : IRepo<Product, int>
    {
        private readonly ShopContext _context;
        private readonly ILogger<ProductRepo> _logger;

        public ProductRepo(ShopContext context,ILogger<ProductRepo> logger)
        {
            _context = context;
            _logger = logger;
        }
        public bool Add(Product t)
        {
            try
            {
                _context.Products.Add(t);
                _context.SaveChanges();
                _logger.LogInformation("Procduct added", t);
                return true;
            }

            catch (Exception e)
            {
                _logger.LogError("Could not add the product " + DateTime.Now.ToString());
                _logger.LogError("The details " + e.Message);
            }
            return false;
        }

        public bool Delete(int k)
        {
            throw new NotImplementedException();
        }

        public bool Edit(int k, Product t)
        {
            throw new NotImplementedException();
        }

        public Product Get(int k)
        {
            try
            {
                var product = _context.Products.SingleOrDefault(p => p.Id == k);
                return product;
            }
            catch(ArgumentNullException ane)
            {
                _logger.LogError("The argument is null " + ane.Message);
            }
            catch (Exception e)
            {
                _logger.LogError("The details " + e.Message);
            }
            return null;
        }

        public ICollection<Product> GetAll()
        {
           if(_context.Products.Count() ==0)
            {
                return null;
            }
            return _context.Products.ToList();
        }
    }
}
