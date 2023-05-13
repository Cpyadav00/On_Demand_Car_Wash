using Microsoft.EntityFrameworkCore;
using On_Demand_Car_Wash.DataBaseContext;
using On_Demand_Car_Wash.Interface;
using On_Demand_Car_Wash.Model;

namespace On_Demand_Car_Wash.Repository
{
    public class CarRepository : ICar
    {
        private CarDbContext _carDb;
        public CarRepository(CarDbContext carDbContext)
        {
            _carDb = carDbContext;
        }
        public List<Car> GetAllCar()
        {
            List<Car> cars = null;
            try
            {
                cars = _carDb.Cars.ToList();
            }
            catch (Exception ex) { }
            return cars;
        }

        public Car GetCar(int id)
        {
            Car car;
            try
            {
                car = _carDb.Cars.Find(id);
                if (car != null)
                {
                    return car;
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentNullException();
            }
            finally
            {
                car = null;
            }
            return car;
        }
        public string AddCar(Car car)
        {
            string result = string.Empty;
            try
            {
                _carDb.Cars.Add(car);
                _carDb.SaveChanges();
            }
            catch (Exception ex)
            {
                result = "400";
            }
            return result;
        }
        public string UpdateCar(int id, Car car)
        {
            string result = string.Empty;
            try
            {
                var obj = _carDb.Cars.AsNoTracking().SingleOrDefault((a=>a.Id==id));
                if (obj == null)
                {
                    result = "Id is not present in database";
                    return result;
                }
                _carDb.Cars.Update(car);
                _carDb.SaveChanges();
                result = "200";
            }
            catch
            {
                result = "400";
            }
            return result;
        }
        public string DeleteCar(int id)
        {
            string result = string.Empty;
            Car car;
            try
            {
                car = _carDb.Cars.Find(id);
                if (car != null)
                {
                    _carDb.Cars.Remove(car);
                    _carDb.SaveChanges();
                    result = "200";
                }
            }
            catch (Exception ex)
            {
                result = "400";
            }
            finally
            {
                car = null;
            }
            return result;
        }
    }
}
