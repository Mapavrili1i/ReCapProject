using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            Console.WriteLine("------------Tümünü Listeleme----------------");
            ShowDescription(carManager);

            Console.WriteLine("------------Ekleme----------------");
            Car car1 = new Car { Id = 6, BrandId = 3, ColorId = "1", DailyPrice = 10000, Description = "Volvo S60", ModelYear = 2015 };
            carManager.AddCar(car1);
            ShowDescription(carManager);

            Console.WriteLine("----------Güncelleme------------------");
            Car car2 = new Car { Id = 6, BrandId = 2, ColorId = "1", DailyPrice = 10000, Description = "Volvo S40", ModelYear = 2015 };
            carManager.UpdateCar(car2);
            ShowDescription(carManager);

            Console.WriteLine("----------Silme------------------");
            carManager.DeleteCar(6);
            ShowDescription(carManager);

            Console.WriteLine("----------Id Listeleme------------------");
            Console.WriteLine(carManager.GetByIdCar(1).Description);



        }
        private static void ShowDescription(CarManager carManager)
        {
            foreach (var car in carManager.GetAllCar())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}



