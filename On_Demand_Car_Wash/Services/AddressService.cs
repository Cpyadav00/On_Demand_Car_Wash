using On_Demand_Car_Wash.Interface;
using On_Demand_Car_Wash.Model;

namespace On_Demand_Car_Wash.Services
{
    public class AddressService
    {
        private IAddress _IAddress;
        public AddressService(IAddress Iaddress)
        {
            _IAddress = Iaddress;
        }
        public List<Address> GetAllAddress()
        {
            return _IAddress.GetAllAddress();
        }
        public Address GetAddress(int id)
        {
            return _IAddress.GetAddress(id);
        }
        public string AddAddress(Address address)
        {
            return _IAddress.AddAddress(address);
        }
        public string UpdateAddress(int id, Address address)
        {
            return _IAddress.UpdateAddress(id,address);
        }
        public string DeleteAddress(int id)
        {
            return _IAddress.DeleteAddress(id);
        }
    }
}
