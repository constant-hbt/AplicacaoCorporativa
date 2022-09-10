using Core.Domain;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AplicacaoCorporativa.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        // GET: api/<CustomerController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new List<Customer>()
            {
                new Customer
                {
                    Id = 1,
                    Name = "Henrique",
                    BirthDate = new DateTime(1999, 12, 17),
                },
                new Customer
                {
                    Id = 2,
                    Name = "Neusa",
                    BirthDate = new DateTime(1968, 10, 17),
                }
            });
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CustomerController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
