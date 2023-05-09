using Microsoft.AspNetCore.Mvc;
using On_Demand_Car_Wash.IRepository;
using On_Demand_Car_Wash.Model;
using On_Demand_Car_Wash.Repository;

namespace On_Demand_Car_Wash.Controllers
{
    [ApiController]
    public class CustomerController : Controller
    {
        ICustomerRepository repository;

        public CustomerController(ICustomerRepository _repository)
        {
            this.repository = _repository;
            
        }

        // For Getting all the Customer Details

        [Route("Customer/GetAll")]
        [HttpGet]
        public async Task<ActionResult<List<Customer>>> GetAll()
        {

            try
            {
                var customerList = await repository.GetAllCustomers();
                return Ok(customerList);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
                 
        }

        //For Updating custmer details using id

        [Route("Customer/GetById/{id}")]
        [HttpGet]
        public async Task<ActionResult<Customer>> GetById(int id)
        {
            try
            {
                var customer= await repository.GetCustomersById(id);
                return Ok(customer);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //For Adding new customer details

        [Route("Customer/Put/{id}")]
        [HttpPost]
        public async Task<ActionResult<Customer>> Put(int id,[FromBody]Customer obj)
        {
            try
            {
                var customer = await repository.UpdateCustomers(id,obj);
                return Ok(customer);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //For Adding new custmer details 

        [Route("Customer/Post")]
        [HttpPost]
        public async Task<ActionResult<Customer>> Post(Customer customer)
        {
            try
            {
                var cust = await repository.AddingNewCustomer(customer);
                return Ok(cust);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



        //For Deleting the Existing data Using id

        [Route("Customer/Delete/{id}")]
        [HttpGet]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            try
            {
                var customer = await repository.DeleteCustomer(id);
                if (customer)
                    return Ok(true);
                else
                    return Ok(false);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
