using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace On_Demand_Car_Wash.Model
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Please provide name")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please prove address")]
        [StringLength(50)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please provide city")]
        [DataType(DataType.Text)]
        public string City { get; set; }

        [Required(ErrorMessage = "Please provide postal code")]
        [DataType(DataType.PostalCode)]
        public int PostalCode { get; set; }
        [Required(ErrorMessage = "Please provide phone number")]
        [DataType(DataType.PhoneNumber)]
        public long Phone { get; set; }
        [Required(ErrorMessage = "Please provide a email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please provide a password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime WashingDate { get; set; }
        [Required]
        public int AccountDetailId { get; set; }
        [Required]
        public int WasherId { get; set; }
        [Required]
        public int OrderId { get; set; }
        [Required]
        public int ServiceId { get; set; }
        [Required]
        public int PaymentId { get; set; }
        //[ForeignKey("AccountDetailId")]

        //public AccountDetail AccountDetail { get; set; }
        //[ForeignKey("WasherId")]
        //public Washer Washer { get; set; }



        //[ForeignKey("OrderId")]
        //public Order Order { get; set; }
        //[ForeignKey("ServiceId")]
        //public Service Services { get; set; }


        //[ForeignKey("PaymentId")]
        //public Payment Payment { get; set; }

    }
}
