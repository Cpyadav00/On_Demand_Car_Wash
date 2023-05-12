using Microsoft.EntityFrameworkCore;
using On_Demand_Car_Wash.DataBaseContext;
using On_Demand_Car_Wash.Interface;
using On_Demand_Car_Wash.Model;

namespace On_Demand_Car_Wash.Repository
{
    public class AdminRepository : IAdmin
    {
        private CarDbContext _adminDb;
        public AdminRepository(CarDbContext adminDbContext)
        {
            _adminDb = adminDbContext;
        }
        public List<Admin> GetAllAdmin()
        {
            List<Admin> admins = null;
            try
            {
                admins = _adminDb.Admins.ToList();
            }
            catch (Exception ex) { }
            return admins;
        }
        public Admin GetAdmin(int id)
        {
            Admin admin;
            try
            {
                admin = _adminDb.Admins.Find(id);
                if (admin != null)
                {
                    return admin;
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentNullException();
            }
            finally
            {
                admin = null;
            }
            return admin;
        }
        public string AddAdmin(Admin admin)
        {
            string result = string.Empty;
            try
            {
                _adminDb.Admins.Add(admin);
                _adminDb.SaveChanges();
            }
            catch (Exception ex)
            {
                result = "400";
            }
            return result;
        }
        public string UpdateAdmin(int id, Admin admin)
        {
            string result = string.Empty;
            try
            {
                var obj = _adminDb.Admins.Find(id);
                if (obj != null)
                {
                    result = "Id is not present in database";
                    return result;
                }
                _adminDb.Entry(admin).State = EntityState.Modified;
                _adminDb.SaveChanges();
                result = "200";
            }
            catch
            {
                result = "400";
            }
            return result;
        }
        public string DeleteAdmin(int id)
        {
            string result = string.Empty;
            Admin admin;
            try
            {
                admin = _adminDb.Admins.Find(id);
                if (admin != null)
                {
                    //package.Status = "In Active";
                    _adminDb.Admins.Remove(admin);
                    _adminDb.SaveChanges();
                    result = "200";
                }
            }
            catch (Exception ex)
            {
                result = "400";
            }
            finally
            {
                admin = null;
            }
            return result;
        }
    }

}
