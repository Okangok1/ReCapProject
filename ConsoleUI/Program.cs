using Business.Concrete;
using DataAccess.Concrete.InMemory;
using IEntities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //GeçiçiVeriTabanıÇalıştır();

            CarManager carManager = new CarManager(new InMemoryCarDal());
            Car car1 = new Car {
                BrandId = 3,
                ColorId = 2,
                DailyPrice = 2,
                Description = "Audi ",
                Id=1,
                ModelYear="2002"
            };
            carManager.Add(car1);
            for (int i = 0; i < 15; i++)
            {
                Random rastgele = new Random();
                int randomCars = rastgele.Next(1, 10);
                
                Car cari = new Car
                {
                    
                    BrandId = randomCars,
                    ColorId = randomCars-1,
                    DailyPrice = randomCars+3,
                    Description = "Audi  "+randomCars,
                    Id = 1+(randomCars/2)+2,
                    ModelYear = "randomCars"
                };
                Console.WriteLine("Id : "+cari.Id+" brand ıd: " +cari.BrandId+"  Color ıd: "+ cari.ColorId+" Daily price: " 
                    + cari.DailyPrice+"  Description :"+ cari.Description+" ");
            }
            
        }

        private static void GeçiçiVeriTabanıÇalıştır()
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Model yılı : " + car.ModelYear + "  Fiyat : " + car.DailyPrice + "    Açıklama : " + car.Description);
            }
        }
    }
}
