using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace On_Demand_Car_Wash.Model
{
    public class Washer
    {
        [Key]
        public int WasherId { get; set; }
        [Required(ErrorMessage ="Please provide name")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [DefaultValue(0)]
        public float Rating { get; set; }

        [Required(ErrorMessage ="Please provide password")]
        [ DataType(DataType.Password)]
        public string Password { get; set; }
       
        [DefaultValue(false)]
        public bool IsApproved { get; set; }
        [DefaultValue(true)]
        public bool IsAvilable { get; set; }
        [Required(ErrorMessage ="Please provide email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage ="Please provide phone number")]
        [DataType(DataType.PhoneNumber)]
        public long PhoneNumber { get; set; }

        public int AccountDetailId { get; set; }
        [Required]
        public int OrderId { get; set; }
        [Required]
        public int PaymentId { get; set; }

        //[ForeignKey("OrderId")]
        //public Order Order { get; set; }

        //[ForeignKey("AccountDetailId")]
        //public AccountDetail AccountDetail { get; set; }

        //[ForeignKey("PaymentId")]
        //public Payment Payment { get; set; }

    }
}
