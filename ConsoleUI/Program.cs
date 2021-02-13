using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryProductDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("CarId ="+car.Id);
                Console.WriteLine("Brand ="+car.BrandId);
                Console.WriteLine("Daily Price ="+car.DailyPrice);
                Console.WriteLine("Description ="+car.Description);
                Console.WriteLine("Model Year ="+car.ModelYear);
                Console.WriteLine();

            }
        }
    }
}
