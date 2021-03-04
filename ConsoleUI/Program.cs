using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using IEntities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
         

            //RandomCars();

           RentalManager rentalManager=new RentalManager(new EfRentalDal());
            var result2 = rentalManager.Add(
                new Rental
                {
                    CarId = 1,
                    CustomerId = 1,
                    RentalId=2,
                    RentalName="kiralık araç",
                    RentDate=DateTime.Now,
                    ReturnDate= new DateTime ( 2020 , 4, 15)

                });
            Console.WriteLine(result2.Message);

            //CarManager carManager = new CarManager(new EfCarDal());
            //var result = carManager.GetCarDetails();
            //if (result.Success==true)
            //{
            //    foreach (var car in result.Data)
            //    {
            //        Console.WriteLine(car.DailyPrice);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}


        }


        private static void RandomCars()
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            for (int i = 0; i < 15; i++)
            {
                Random rastgele = new Random();
                int randomCars = rastgele.Next(1, 10);

                Car cari = new Car
                {

                    BrandId = randomCars,
                    ColorId = randomCars - 1,
                    DailyPrice = randomCars + 3,
                    Description = "Audi  " + randomCars,
                    Id = 1 + (randomCars / 2) + 2,
                    ModelYear = "randomCars"
                };
                Console.WriteLine("Id : " + cari.Id + " brand ıd: " + cari.BrandId + "  Color ıd: " + cari.ColorId + " Daily price: "
                    + cari.DailyPrice + "  Description :" + cari.Description + " ");
            }
        }

        
    }
}
