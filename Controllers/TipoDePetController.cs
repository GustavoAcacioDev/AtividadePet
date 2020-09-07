using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtividadePet.Domains;
using AtividadePet.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AtividadePet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoDePetController : ControllerBase
    {

        TipoDePetRepository repo = new TipoDePetRepository();

        // GET: api/<TipoDePetController>
        [HttpGet]
        public List<TipoDePet> Get()
        {
            return repo.LerTodos();
        }

        // GET api/<TipoDePetController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TipoDePetController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TipoDePetController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TipoDePetController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
