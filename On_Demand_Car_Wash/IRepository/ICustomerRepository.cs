using Microsoft.AspNetCore.Mvc;
using On_Demand_Car_Wash.Model;
using System.Threading.Tasks;

namespace On_Demand_Car_Wash.IRepository
{
   public interface ICustomerRepository
    {
        // For Getting all the Customer Details
       Task <IEnumerable<Customer>> GetAllCustomers();
        //For Getting Details of single customer using id
       Task<Customer> GetCustomersById(int id);

        //For Updating custmer details using id
       Task<Customer> UpdateCustomers(int id,Customer obj);

        //For Adding new custmer details 
        Task<Customer> AddingNewCustomer(Customer obj);

        //For Deleting the Existing data Using id
        Task<bool> DeleteCustomer(int id);
    }
}
