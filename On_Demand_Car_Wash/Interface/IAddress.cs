using On_Demand_Car_Wash.Model;

namespace On_Demand_Car_Wash.Interface
{
    public interface IAddress
    {
        List<Address> GetAllAddress();
        Address GetAddress(int id);
        public string AddAddress(Address address);
        public string UpdateAddress(int id,Address address);
        public string DeleteAddress(int id);
    }
}
