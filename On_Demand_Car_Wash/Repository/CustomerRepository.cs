using Microsoft.EntityFrameworkCore;
using On_Demand_Car_Wash.DataBaseContext;
using On_Demand_Car_Wash.IRepository;
using On_Demand_Car_Wash.Model;

namespace On_Demand_Car_Wash.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        CarDbContext context;
        public CustomerRepository(CarDbContext context)
        {
            this.context = context;
        }

        // For Getting all the Customer Details
        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            return await context.Customers.ToListAsync();
        }

        //For Getting Details of single customer using id
        public async Task<Customer> GetCustomersById(int id)
        {
            Customer customer=await context.Customers.Where(a=>a.CustomerId==id).SingleOrDefaultAsync();
            if (customer != null)
            {
                return customer;
            }
            else
                return null;
        }

        //For Updating custmer details using id
        public async Task<Customer> UpdateCustomers(int id,Customer obj)
        {
            Customer customer=await context.Customers.Where(a => a.CustomerId == id).FirstOrDefaultAsync();
            if (customer != null && obj != null)
            {
                 context.Customers.Update(obj);
                await context.SaveChangesAsync();
                return customer;
            }
            else
                return obj;
        }


        //For Adding new customer details
       public async Task<Customer> AddingNewCustomer(Customer obj)
        {
            if(obj != null)
            {
                await context.Customers.AddAsync(obj);
                await context.SaveChangesAsync();
                return obj;
            }
            else
            {
                return obj;
            }
        }

        //For Deleting the Existing data Using id
        public async Task<bool> DeleteCustomer(int id)
        {
         var customer=await context.Customers.Where(a=>a.CustomerId == id).SingleOrDefaultAsync();
            if (customer != null)
            {
                context.Customers.Remove(customer);
               await context.SaveChangesAsync();
                return true;
            }
            else
                return false;
        }
    }
}
