using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var item in productManager.GetByUnitPrice(50,100))
            {
                Console.WriteLine(item.ProductName+" "+item.UnitPrice);
            }

            //foreach (var item in productManager.GetAllByCategoryId(2))
            //{
            //    Console.WriteLine(item.ProductName);
            //}

        }
    }
}
