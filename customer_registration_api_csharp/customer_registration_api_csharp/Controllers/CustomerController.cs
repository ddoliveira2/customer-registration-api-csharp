using customer_registration_api_csharp.Model.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace customer_registration_api_csharp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpGet("one/{customerId}")]
        public IActionResult GetOneCustomer(string customerId) 
        {
            return Ok();
        }

        [HttpGet("list/{name}/{rg}/{cpf}")]
        public IActionResult GetListCustomer(string name,  string rg,  string cpf)
        {
            return Ok();
        }

        [HttpPost("create")]
        public IActionResult CreateCustomer([FromBody] RequestCreateUpdateCustomer customer)
        {
            return Ok();
        }

        [HttpPut("update/{customerId}")]
        public IActionResult UpdateCustomer([FromBody] RequestCreateUpdateCustomer customer,  string customerId)
        {
            return Ok();
        }

        [HttpDelete("delete/{customerId}")]
        public IActionResult DeleteCustomer(string customerId)
        {
            return Ok();
        }
    }
}
