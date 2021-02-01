using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAllCar();//tamam
        Car GetByIdCar(int carId);
        void AddCar(Car car);//tma
        void DeleteCar(int carId);//tamam
        void UpdateCar(Car car);

    }
}
