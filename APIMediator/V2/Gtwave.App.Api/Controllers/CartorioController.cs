using MediatR;
using Microsoft.AspNetCore.Mvc;
using Gtwave.App.Domain.Commands.Requests;
using Gtwave.App.Domain.Commands.Response;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gtwave.App.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartorioController : ControllerBase
    {
        // GET: api/<CartorioController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CartorioController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CartorioController>
        [HttpPost]
        public Task<CreateCartorioResponse> Post(
            [FromServices] IMediator mediator,
            [FromBody] CreateCartorioRequest command)
        {
             return mediator.Send(command);
        }

        // PUT api/<CartorioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CartorioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
