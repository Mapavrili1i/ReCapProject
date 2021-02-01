﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetAll();
        Car GetById(int carId);   
        void Add(Car car);
        void Delete(int carId);
        void Update(Car car);

    }
}
