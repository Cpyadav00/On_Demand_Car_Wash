using On_Demand_Car_Wash.Model;

namespace On_Demand_Car_Wash.Interface
{
    public interface IViewInvoice
    {
        List<Invoice> ViewInvoiceAsync(int id);
    }
}
