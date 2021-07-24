using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();
            //CategoryTest();
            //ProductSelfServiceTest();



        }

        //private static void ProductSelfServiceTest()
        //{
        //    ProductManager productManager = new ProductManager(new EfProductDal());

        //    var result = productManager.isThatExisting(1);
            
            
        //}

        //private static void CategoryTest()
        //{
        //    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

        //    foreach (var category in categoryManager.GetAll())
        //    {
        //        Console.WriteLine(category.CategoryName);
        //    }
        //}

        private static void ProductTest()
        {
            //ProductManager productManager = new ProductManager(new EfProductDal());

            //foreach (var item in productManager.GetProductDetails().Data)
            //{
            //    Console.WriteLine(item.ProductName + " " + item.CategoryName);
            //}
            //Console.WriteLine(productManager.GetProductDetails().Message);
        }
    }
}
