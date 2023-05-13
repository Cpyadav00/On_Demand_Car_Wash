using On_Demand_Car_Wash.Interface;
using On_Demand_Car_Wash.Model;

namespace On_Demand_Car_Wash.Services
{
    public class ViewInvoiceService
    {
        private IViewInvoice _repository;
        public ViewInvoiceService(IViewInvoice repository)
        {
            _repository = repository;
        }
        public List<Invoice> ViewInvoice(int id)
        {
            return _repository.ViewInvoiceAsync(id);
        }
    }
}
