using Microsoft.EntityFrameworkCore;
using On_Demand_Car_Wash.DataBaseContext;
using On_Demand_Car_Wash.Interface;
using On_Demand_Car_Wash.Model;

namespace On_Demand_Car_Wash.Repository
{
    public class PackageRepository : IPackage
    {
        private CarDbContext _packageDb;
        public PackageRepository(CarDbContext packageDbContext)
        {
            _packageDb = packageDbContext;
        }
        #region GetAllPackage
        public List<Package> GetAllPackage()
        {
            List<Package> packages = null;
            try
            {
                packages = _packageDb.Packages.ToList();
            }
            catch (Exception ex) { }
            return packages;
        }
        #endregion
        #region GetPackageById
        public Package GetPackage(int id)
        {
            Package package;
            try
            {
                package = _packageDb.Packages.Find(id);
                if (package != null)
                {
                    return package;
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentNullException();
            }
            finally
            {
                package = null;
            }
            return package;
        }
        #endregion
        #region AddPackage
        public string AddPackage(Package package)
        {
            string result = string.Empty;
            try
            {
                _packageDb.Packages.Add(package);
                _packageDb.SaveChanges();
            }
            catch (Exception ex)
            {
                result = "400";
            }
            return result;
        }
        #endregion
        #region UpdatePackage
        public string UpdatePackage(int id, Package package)
        {
            string result = string.Empty;
            try
            {
                var obj = _packageDb.Packages.Find(id);
                if (obj == null)
                {
                    result = "Id is not present in database";
                    return result;
                }
                _packageDb.Entry(package).State = EntityState.Modified;
                _packageDb.SaveChanges();
                result = "200";
            }
            catch
            {
                result = "400";
            }
            return result;
        }
        #endregion
        #region DeletePackage
        public string DeletePackage(int id)
        {
            string result = string.Empty;
            Package package;
            try
            {
                package = _packageDb.Packages.Find(id);
                if (package != null)
                {
                    //package.Status = "In Active";
                    _packageDb.Packages.Remove(package);
                    _packageDb.SaveChanges();
                    result = "200";
                }
            }
            catch (Exception ex)
            {
                result = "400";
            }
            finally
            {
                package = null;
            }
            return result;
        }
        #endregion
    }
}
