using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
   public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car{Id=1 , BrandId=1 , ColorId="1" ,DailyPrice=10000 , ModelYear=2010 , Description="Audi TT" },
                new Car{Id=2 , BrandId=2 , ColorId="1" ,DailyPrice=10000 , ModelYear=2010 , Description="Mercedes Kompresor" },
                new Car{Id=3 , BrandId=3 , ColorId="1" ,DailyPrice=10000 , ModelYear=2010 , Description="Volvo S40" },
                new Car{Id=4 , BrandId=1 , ColorId="1" ,DailyPrice=10000 , ModelYear=2010 , Description="Audi A6" },
                new Car{Id=5 , BrandId=2 , ColorId="1" ,DailyPrice=10000 , ModelYear=2010 , Description="Mercedes Vito" },
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(int carId)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == carId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int carId)
        {
            return _cars.SingleOrDefault(c => c.Id == carId);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            Car productToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            //carToUpdate.Id = car.Id;
            //carToUpdate.BrandId = car.BrandId;
            //carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;  
        }
    }
}
