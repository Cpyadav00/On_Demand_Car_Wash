using Microsoft.EntityFrameworkCore;
using On_Demand_Car_Wash.DataBaseContext;
using On_Demand_Car_Wash.Interface;
using On_Demand_Car_Wash.Model;

namespace On_Demand_Car_Wash.Repository
{
    public class AddressRepository : IAddress
    {
        private CarDbContext _addressDb;
        public AddressRepository(CarDbContext addressDbContext)
        {
            _addressDb = addressDbContext;
        }
        public List<Address> GetAllAddress()
        {
            List<Address> address = null;
            try
            {
                address = _addressDb.Address.ToList();
            }
            catch (Exception ex) { }
            return address;
        }
        public Address GetAddress(int id)
        {
            Address address;
            try
            {
                address = _addressDb.Address.Find(id);
                if (address != null)
                {
                    return address;
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentNullException();
            }
            finally
            {
                address = null;
            }
            return address;
        }
        public string AddAddress(Address address)
        {
            string result = string.Empty;
            try
            {
                _addressDb.Address.Add(address);
                _addressDb.SaveChanges();
            }
            catch (Exception ex)
            {
                result = "400";
            }
            return result;
        }
        public string UpdateAddress(Address address)
        {
            string result = string.Empty;
            try
            {
                _addressDb.Entry(address).State = EntityState.Modified;
                _addressDb.SaveChanges();
                result = "200";
            }
            catch
            {
                result = "400";
            }
            return result;
        }
        public string DeleteAddress(int id)
        {
            string result = string.Empty;
            Address address;
            try
            {
                address = _addressDb.Address.Find(id);
                if (address != null)
                {
                    //package.Status = "In Active";
                    _addressDb.Address.Remove(address);
                    _addressDb.SaveChanges();
                    result = "200";
                }
            }
            catch (Exception ex)
            {
                result = "400";
            }
            finally
            {
                address = null;
            }
            return result;
        }
    }
}
