using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace On_Demand_Car_Wash.Model
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public int WasherId { get; set; }
        [Required]
        public double Amount { get; set; }
        [Required]
        [DefaultValue(false)]
        public bool Status { get; set; }
        [Required]
        public int ServiceId { get; set; }
        [Required]
        public DateTime ShudelingTime { get; set; }
        [Required]
        public string Address { get; set; }

        //[ForeignKey("ServiceId")]

        //public Service Services { get; set; }

        //[ForeignKey("CustomerId")]
        ////[ValidateNever]
        //public Customer Customer { get; set; }

        //[ForeignKey("WasherId")]
        //public Washer Washer { get; set; }

    }
}
