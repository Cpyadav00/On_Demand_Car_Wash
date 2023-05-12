using On_Demand_Car_Wash.Model;

namespace On_Demand_Car_Wash.Interface
{
    public interface IAdmin
    {
        List<Admin> GetAllAdmin();
        Admin GetAdmin(int id);
        public string AddAdmin(Admin admin);
        public string UpdateAdmin(int id,Admin admin);
        public string DeleteAdmin(int id);
    }
}
