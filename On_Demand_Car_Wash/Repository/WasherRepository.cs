using Microsoft.EntityFrameworkCore;
using On_Demand_Car_Wash.DataBaseContext;
using On_Demand_Car_Wash.IRepository;
using On_Demand_Car_Wash.Model;

namespace On_Demand_Car_Wash.Repository
{
    public class WasherRepository: IWasherRepository
    {

        CarDbContext context;
        public WasherRepository(CarDbContext context)
        {
            this.context = context;
        }

        // For Getting all the Washer Details
        public async Task<IEnumerable<Washer>> GetAllWasher()
        {
            return await context.Washers.ToListAsync();
        }

        //For Getting Details of single Washer using id
        public async Task<Washer> WasherById(int id)
        {
            Washer washer = await context.Washers.Where(a => a.WasherId == id).SingleOrDefaultAsync();
            if (washer != null)
            {
                return washer;
            }
            else
                return null;
        }

        //For Updating Washer details using id
        public async Task<Washer> UpdateWasher(int id, Washer obj)
        {
            Washer washer = await context.Washers.Where(a => a.WasherId == id).FirstOrDefaultAsync();
            if (washer != null && obj != null)
            {
                context.Washers.Update(obj);
                await context.SaveChangesAsync();
                return washer;
            }
            else
                return obj;
        }


        //For Adding new Washer details
        public async Task<Washer> AddingNewWasher(Washer obj)
        {
            if (obj != null)
            {
                await context.Washers.AddAsync(obj);
                await context.SaveChangesAsync();
                return obj;
            }
            else
            {
                return obj;
            }
        }



        //For Deleting the Existing data Using id
        public async Task<bool> DeleteWasher(int id)
        {
            var washer = await context.Washers.Where(a => a.WasherId == id).SingleOrDefaultAsync();
            if (washer != null)
            {
                context.Washers.Remove(washer);
                await context.SaveChangesAsync();
                return true;
            }
            else
                return false;
        }

    }
}
