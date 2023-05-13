using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using On_Demand_Car_Wash.Model;
using On_Demand_Car_Wash.Services;
using System.Data;

namespace On_Demand_Car_Wash.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackageController : ControllerBase
    {
        private PackageService packageService;
        public PackageController(PackageService _packageService)
        {
            packageService = _packageService;
        }
       
        [HttpGet("GetAllPackage")]
        public IActionResult GetAllPackage()
        {
            return Ok(packageService.GetAllPackage());
        }
        [HttpGet("GetPackage/{id}")]
        public IActionResult GetPackage(int id)
        {
            return Ok(packageService.GetPackage(id));
        }
        [HttpPost("AddPackage")]
        public IActionResult AddPackage(Package package)
        {
            return Ok(packageService.AddPackage(package));
        }
        [HttpPut("UpdatePackage/{id}")]
        public IActionResult UpdatePackage(int id,[FromBody]Package package)
        {
            return Ok(packageService.UpdatePackage(id, package));
        }
        [HttpDelete("DeletePackage/{id}")]
        public IActionResult DeletePackage(int id)
        {
            return Ok(packageService.DeletePackage(id));
        }
    }
}
