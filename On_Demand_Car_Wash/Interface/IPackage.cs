using On_Demand_Car_Wash.Model;

namespace On_Demand_Car_Wash.Interface
{
    public interface IPackage
    {
        List<Package> GetAllPackage();
        Package GetPackage(int id);
        public string AddPackage(Package package);
        public string UpdatePackage(int id,Package package);
        public string DeletePackage(int id);
    }
}
