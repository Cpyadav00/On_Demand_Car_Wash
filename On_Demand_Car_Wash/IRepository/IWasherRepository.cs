using On_Demand_Car_Wash.Model;

namespace On_Demand_Car_Wash.IRepository
{
    public interface IWasherRepository
    {

        // For Getting all the Washer Details
        Task<IEnumerable<Washer>> GetAllWasher();

        //For Getting Details of single Washer using id
        Task<Washer> WasherById(int id);

        //For Updating Washer details using id
        Task<Washer> UpdateWasher(int id, Washer obj);

        //For Adding new Washer details 
        Task<Washer> AddingNewWasher(Washer obj);

        //For Deleting the Existing data Using id
        Task<bool> DeleteWasher(int id);
    }
}
