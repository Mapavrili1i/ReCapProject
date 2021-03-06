﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void AddCar(Car car)
        {
            _carDal.Add(car);
        }

        public void DeleteCar(int carId)
        {
            _carDal.Delete(carId);
        }

        public List<Car> GetAllCar()
        {
           
            return _carDal.GetAll();
        }

        public Car GetByIdCar(int carId)
        {
            return _carDal.GetById(carId);    
        }

        public void UpdateCar(Car car)
        {
            _carDal.Update(car);
        }
    }
}
