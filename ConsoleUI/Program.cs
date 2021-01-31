using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("araba no = "+ car.BrandId );
                Console.WriteLine("vites = "+car.Description);
                Console.WriteLine("günlük ücret =" +car.DailyPrice);
                Console.WriteLine(" \n  ");
            }
        }
    }
}
        
