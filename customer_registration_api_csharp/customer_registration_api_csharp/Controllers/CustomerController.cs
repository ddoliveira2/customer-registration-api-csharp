using customer_registration_api_csharp.Bll;
using customer_registration_api_csharp.Dal.Dao;
using customer_registration_api_csharp.Model.Model;
using customer_registration_api_csharp.Model.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace customer_registration_api_csharp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private CustomerBll _bll;
        private Customer _customer;
        private List<Customer> _listCustomer;
        private string _msg;

        public CustomerController(SqlServerContext context)
        {
            this._bll = new CustomerBll(context);
            this._customer = new Customer();
            this._listCustomer = new List<Customer>();
        }


        [HttpGet("one/{customerId}")]
        public IActionResult GetOneCustomer(string customerId)
        {
            try
            {
                _customer = _bll.GetOneCustome(customerId);
                return Ok(new
                {
                    status_code = 200,
                    message = "Registro de Cliente",
                    data = _customer
                });
            }
            catch (Exception ex)
            {
                return BadRequest(
                    new
                    {
                        status_code = 500,
                        message = ex.Message
                    });
            }
        }

        [HttpGet("list/{name}/{rg}/{cpf}")]
        public IActionResult GetListCustomer(string name = "", string rg = "", string cpf = "")
        {
            try
            {
                _listCustomer = _bll.GetListCustomer(name,rg,cpf);
                return Ok(new
                {
                    status_code = 200,
                    message = "Lista de Clientes",
                    data = _listCustomer
                });
            }
            catch (Exception ex)
            {
                return BadRequest(
                    new
                    {
                        status_code = 500,
                        message = ex.Message
                    });
            }
        }

        [HttpPost("create")]
        public IActionResult CreateCustomer([FromBody] RequestCreateUpdateCustomer customer)
        {
            try
            {
                _customer = _bll.CreateCustomer(customer, out _msg);
                return Ok(new
                {
                    status_code = 200,
                    message = _msg,
                    data = _customer
                });
            }
            catch (Exception ex)
            {
                return BadRequest(
                    new
                    {
                        status_code = 500,
                        message = ex.Message
                    });
            }
        }

        [HttpPut("update/{customerId}")]
        public IActionResult UpdateCustomer([FromBody] RequestCreateUpdateCustomer customer, string customerId)
        {
            try
            {
                _customer = _bll.UpdateCustomer(customerId, customer,out _msg);
                return Ok(new
                {
                    status_code = 200,
                    message = _msg,
                    data = _customer
                });
            }
            catch (Exception ex)
            {
                return BadRequest(
                    new
                    {
                        status_code = 500,
                        message = ex.Message
                    });
            }
        }

        [HttpDelete("delete/{customerId}")]
        public IActionResult DeleteCustomer(string customerId)
        {
            try
            {
                _customer = _bll.DeleteCustomer(customerId,out _msg);
                return Ok(new
                {
                    status_code = 200,
                    message = _msg,
                    data = _customer
                });
            }
            catch (Exception ex)
            {
                return BadRequest(
                    new
                    {
                        status_code = 500,
                        message = ex.Message
                    });
            }
        }
    }
}
