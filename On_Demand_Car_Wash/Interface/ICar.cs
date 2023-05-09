﻿using On_Demand_Car_Wash.Model;

namespace On_Demand_Car_Wash.Interface

{
    public interface ICar
    {
        List<Car> GetAllCar();
        Car GetCar(int id);
        public string AddCar(Car car);
        public string UpdateCar(Car car);
        public string DeleteCar(int id);
    }
}
