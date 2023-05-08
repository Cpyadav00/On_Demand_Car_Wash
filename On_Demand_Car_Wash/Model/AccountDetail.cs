using System.ComponentModel.DataAnnotations;

namespace On_Demand_Car_Wash.Model
{
    public class AccountDetail
    {
        [Key]
        public int AccountDetailId { get; set; }
        [Required(ErrorMessage ="Please provide account holder name")]
        [DataType(DataType.Text)]
        public string AccountName { get; set; }
        [Required(ErrorMessage ="please provide account number")]
        public double AccountNumber { get; set; }
        [Required(ErrorMessage ="Please provide ifsc code")]
        public string IfscCode { get; set; }
        [Required(ErrorMessage ="Please provide bank name")]
        [DataType(DataType.Text)]
        public string BankName { get; set; }

    }
}
