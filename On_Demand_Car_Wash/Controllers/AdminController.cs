using Microsoft.AspNetCore.Mvc;
using On_Demand_Car_Wash.Model;
using On_Demand_Car_Wash.Services;

namespace On_Demand_Car_Wash.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private AdminService adminService;
        public AdminController(AdminService _adminService)
        {
            adminService = _adminService;
        }
        [HttpGet("GetAllAdmin")]
        public IActionResult GetAllAdmin()
        {
            return Ok(adminService.GetAllAdmin());
        }
        [HttpGet("GetAdmin/{id}")]
        public IActionResult GetAdmin(int id)
        {
            return Ok(adminService.GetAdmin(id));
        }
        [HttpPost("AddAdmin")]
        public IActionResult AddAdmin(Admin admin)
        {
            return Ok(adminService.AddAdmin(admin));
        }
        [HttpPut("UpdateAdmin/{id}")]
        public IActionResult UpdateAdmin(int id,[FromBody]Admin admin)
        {
            return Ok(adminService.UpdateAdmin(id, admin));
        }
        [HttpDelete("DeleteAdmin/{id}")]
        public IActionResult DeleteAdmin(int id)
        {
            return Ok(adminService.DeleteAdmin(id));
        }
    }
}
