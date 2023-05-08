using System.ComponentModel.DataAnnotations;

namespace On_Demand_Car_Wash.Model
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }

        [Required]
        public int CustomerId { get; set; }
        [Required]
        public int OrderId { get; set; }
        [Required]
        public int WasherId { get;set; }
    }
}
