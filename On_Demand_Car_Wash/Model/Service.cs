using System.ComponentModel.DataAnnotations;

namespace On_Demand_Car_Wash.Model
{
    public class Service
    {
        [Key]
        public int ServiceId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double Amount { get; set; }
    }
}
