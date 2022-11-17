
using Busniess.Abstract;
using Busniess.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    //SOLID
    //Open Closed Princible
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
            //IoC
            //CategoryTest();

        }

        private static void NewMethod()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var item in categoryManager.GetAll())
            {
                Console.WriteLine(item.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetAll();

            foreach (var item in result.Data)
            {
                Console.WriteLine(item.ProductName);
            }

            //------------------------------------------//

            var result2 = productManager.GetProductDetail();


            //------------------------------------------//
            //var result = productManager.GetProductDetail();

            //if (result.Success)
            //{
            //    foreach (var item in result.Data)
            //    {
            //        Console.WriteLine(item.ProductName);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}

            //foreach (var item in productManager.GetProductDetail())
            //{
            //    Console.WriteLine(item.ProductName+ " / "+ item.CategoryName);
            //}


        }
    }
}
