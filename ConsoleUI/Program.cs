using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarManager carManager = new ICarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Model yılı : "+car.ModelYear+"  Fiyat : "+car.DailyPrice+"    Açıklama : "+car.Description);
            }


        }
    }
}
