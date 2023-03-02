using Microsoft.AspNetCore.Mvc;
using CustomersApi.Dtos;
using CustomersApi.Repositories;

namespace CustomersApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : Controller 
    {
        private readonly CustomerDataBaseContext _customerDatabaseContext;
        public CustomerController(CustomerDataBaseContext customerDatabaseContext)
        {
            _customerDatabaseContext = customerDatabaseContext;
        }
    
        

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CustomerDto))]
        public async Task<IActionResult> GetCustomer()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
       
        [ProducesResponseType(StatusCodes.Status404NotFound) ]
        public async Task<IActionResult> GetCustomer(long id)
        {
            var empty = new CustomerDto();

            return new OkObjectResult(empty);

        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CustomerDto))]
        public async Task<IActionResult> DeleteCustomer(long id)
        {
            throw new NotImplementedException();
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(CustomerDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> CreateCustomer(CreateCustomerDto customer)
        {
           CustomerEntity result = await _customerDataBaseContext.Add(customer);

            return new CreatedResult($"http.//localhost:7189/api/customer/{result.Id}", null);
        }
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CustomerDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateCustomer(CustomerDto customer)
        {
            throw new NotImplementedException();
        }
    }
}
