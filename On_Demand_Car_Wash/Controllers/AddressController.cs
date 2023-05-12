using Microsoft.AspNetCore.Mvc;
using On_Demand_Car_Wash.Model;
using On_Demand_Car_Wash.Services;

namespace On_Demand_Car_Wash.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private AddressService addressService;
        public AddressController(AddressService _addressService)
        {
            addressService = _addressService;
        }
        [HttpGet("GetAllAddress")]
        public IActionResult GetAllAddress()
        {
            return Ok(addressService.GetAllAddress());
        }
        [HttpGet("GetAddress/{id}")]
        public IActionResult GetAddress(int id)
        {
            return Ok(addressService.GetAddress(id));
        }
        [HttpPost("AddAddress")]
        public IActionResult AddAddress(Address address)
        {
            return Ok(addressService.AddAddress(address));
        }
        [HttpPut("UpdateAddress/{id}")]
        public IActionResult UpdateAddress(int id, [FromBody] Address address)
        {
            return Ok(addressService.UpdateAddress(address));
        }
        [HttpDelete("DeleteAddress/{id}")]
        public IActionResult DeleteAddress(int id)
        {
            return Ok(addressService.DeleteAddress(id));
        }
    }
}
