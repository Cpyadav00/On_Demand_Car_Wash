using On_Demand_Car_Wash.Model;

namespace On_Demand_Car_Wash.Interface
{
    public interface IOrder
    {
        List<Order> GetAllOrder();
        Order GetOrder(int id);
        public string AddOrder(Order order);
        public string UpdateOrder(Order order);
        public string DeleteOrder(int id);
    }
}
