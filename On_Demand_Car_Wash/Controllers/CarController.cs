using Microsoft.AspNetCore.Mvc;
using On_Demand_Car_Wash.Model;
using On_Demand_Car_Wash.Services;

namespace On_Demand_Car_Wash.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private CarService carService;
        public CarController(CarService _carService)
        {
            carService = _carService;
        }
        [HttpGet("GetAllCar")]
        public IActionResult GetAllCar()
        {
            return Ok(carService.GetAllCar());
        }
        [HttpGet("GetCar/{id}")]
        public IActionResult GetCar(int id)
        {
            return Ok(carService.GetCar(id));
        }
        [HttpPost("AddCar")]
        public IActionResult AddCar(Car car)
        {
            return Ok(carService.AddCar(car));
        }
        [HttpPut("UpdateCar/{id}")]
        public IActionResult UpdateCar(int id,[FromBody]Car car)
        {
            return Ok(carService.UpdateCar(id, car));
        }
        [HttpDelete("DeleteCar/{id}")]
        public IActionResult DeleteCar(int id)
        {
            return Ok(carService.DeleteCar(id));
        }
    }
}
