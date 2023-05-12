using On_Demand_Car_Wash.Interface;
using On_Demand_Car_Wash.Model;

namespace On_Demand_Car_Wash.Services
{
    public class AdminService
    {
        private IAdmin _IAdmin;
        public AdminService(IAdmin Iadmin)
        {
            _IAdmin = Iadmin;
        }
        public List<Admin> GetAllAdmin()
        {
            return _IAdmin.GetAllAdmin();
        }
        public Admin GetAdmin(int id)
        {
            return _IAdmin.GetAdmin(id);
        }
        public string AddAdmin(Admin admin)
        {
            return _IAdmin.AddAdmin(admin);
        }
        public string UpdateAdmin(int id,Admin admin)
        {
            return _IAdmin.UpdateAdmin(id,admin);
        }
        public string DeleteAdmin(int id)
        {
            return _IAdmin.DeleteAdmin(id);
        }
    }
}
