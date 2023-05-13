using System.ComponentModel.DataAnnotations;

namespace On_Demand_Car_Wash.DTO
{
    public class CreateUserDto
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string UserPhnumber { get; set; }

        [Required]
        public string UserEmail { get; set; }

        [Required]
        public string UserPassword { get; set; }

        [Required]
        public string UserStatus { get; set; }

        [Required]
        public string Role { get; set; }
    }
}
