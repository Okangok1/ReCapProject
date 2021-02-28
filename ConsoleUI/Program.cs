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
            //GeçiçiVeriTabanıÇalıştır();

            //RandomCars();

            //CarName, BrandName, ColorName, DailyPrice.

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.Name);
            }

            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.Name);
            }

            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var colorId in carManager.GetCarsByColorId(2))
            {
                Console.WriteLine(colorId.Description);
            }

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
