using On_Demand_Car_Wash.Interface;
using On_Demand_Car_Wash.Model;

namespace On_Demand_Car_Wash.Services
{
    public class CarService
    {
        private ICar _ICar;
        public CarService(ICar Icar)
        {
            _ICar = Icar;
        }
        public List<Car> GetAllCar()
        {
            return _ICar.GetAllCar();
        }
        public Car GetCar(int id)
        {
            return _ICar.GetCar(id);
        }
        public string AddCar(Car car)
        {
            return _ICar.AddCar(car);
        }
        public string UpdateCar(int id,Car car)
        {
            return _ICar.UpdateCar(id,car);
        }
        public string DeleteCar(int id)
        {
            return _ICar.DeleteCar(id);
        }
    }
}
