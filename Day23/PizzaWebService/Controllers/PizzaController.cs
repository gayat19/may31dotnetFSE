using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PizzaWebService.Models;
using PizzaWebService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PizzaWebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private readonly IRepo<Pizza, int> _repo;
        private readonly ILogger<PizzaController> _logger;

        public PizzaController(IRepo<Pizza,int> repo, ILogger<PizzaController> logger )
        {
            _repo = repo;
            _logger = logger;
        }

        // GET: api/<PizzaController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var pizzas = _repo.GetAll();
                return Ok(pizzas);
            }
            catch (Exception e)
            {
                _logger.LogError("Could not get all teh pizzas " + e.Message);
            }
            return BadRequest("No pizzas available");
        }

        // GET api/<PizzaController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var pizza = _repo.Get(id);
                if (pizza != null)
                    return Ok(pizza);
            }
            catch (Exception e)
            {
                _logger.LogError("Could not get the pizza " + e.Message);
            }
            return BadRequest("Unable to fetch the pizza");
        }

        // POST api/<PizzaController>
        [HttpPost]
        public IActionResult Post([FromBody] Pizza pizza)
        {
            try
            {
                int id = _repo.Add(pizza);
                if(id != -1)
                    return Ok(pizza);
            }
            catch (Exception e)
            {
                _logger.LogError("Could not add the pizza " + e.Message);
            }
            return BadRequest("Pizza not added");
        }

        // PUT api/<PizzaController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, Pizza pizza)
        {
            try
            {
                var myPizza = _repo.Update(id,pizza);
                if (myPizza != null)
                    return Ok(pizza);
            }
            catch (Exception e)
            {
                _logger.LogError("Could not update the pizza " + e.Message);
            }
            return BadRequest("Pizza details not updated");
        }

        // DELETE api/<PizzaController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var myPizza = _repo.Delete(id);
                if (myPizza != null)
                    return Ok(myPizza);
            }
            catch (Exception e)
            {
                _logger.LogError("Could not delete " + e.Message);
            }
            return BadRequest("Pizza not delete");
        }
    }
}
