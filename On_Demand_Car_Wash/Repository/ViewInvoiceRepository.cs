using On_Demand_Car_Wash.DataBaseContext;
using On_Demand_Car_Wash.Interface;
using On_Demand_Car_Wash.Model;

namespace On_Demand_Car_Wash.Repository
{
    public class ViewInvoiceRepository : IViewInvoice
    {
        CarDbContext _context;
        public ViewInvoiceRepository(CarDbContext context) => _context = context;
        public List<Invoice> ViewInvoiceAsync(int id)
        {
            try
            {
                var query = (from a in _context.Orders
                             join b in _context.Users
                                 on a.CustId equals b.UserId
                             join d in _context.Cars
                                on a.CarId equals d.Id
                             join e in _context.Packages
                                on a.PackageId equals e.Id

                             select new Invoice()
                             {
                                 CustomerName = b.UserName,
                                 DateTime = a.DateTime,
                                 PaymentStatus = a.PaymentStatus,
                                 OrderTotal = a.TotalCost,
                                 CarName = d.Name,
                                 PackageName = e.Name
                             });
                List<Invoice> list1 = query.ToList();
                return list1;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {

            }
        }
    }
}
