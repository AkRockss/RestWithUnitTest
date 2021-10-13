using Microsoft.AspNetCore.Mvc;
using RestWithUnitTest.Managers;
using RestWithUnitTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestWithUnitTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BicyclesController : ControllerBase
    {

        private readonly ByciclesManager _manager = new ByciclesManager();

        // GET: api/<BicyclesController>
        [HttpGet]
        public IEnumerable<Bycicles> Get()
        {
            return _manager.GetAll();
        }

        // GET api/<BicyclesController>/5
        [HttpGet("{id}")]
        public Bycicles Get(int id)
        {
            return _manager.GetById(id);
        }

        // POST api/<BicyclesController>
        [HttpPost]
        public Bycicles Post([FromBody] Bycicles value)
        {
            return _manager.Add(value);

        }

        // PUT api/<BicyclesController>/5
        [HttpPut("{id}")]
        public Bycicles Put(int id, [FromBody] Bycicles value)
        {
            return _manager.Update(id, value);
        }

        // DELETE api/<BicyclesController>/5
        [HttpDelete("{id}")]
        public Bycicles Delete(int id)
        {
            return _manager.Delete(id);
        }
    }
}
