using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_CONSOLE
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // kiểu var
            Console.WriteLine("Tim hieu ve LINQ!!");
            /*
            //Slide 9 trong chương 3
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
            IEnumerable<int> subset 
                = from i in numbers
                  where i < 10
                   select i;
            foreach (int i in subset) //  có thể thay int bằng var
                Console.WriteLine(" Item: {0} ", i);
            */
            /*
            //Slide 11 kiểu tường minh
            string[] fruits = { "Chuoi", "Thanh Long", "Sau rieng", "Cam", "Dua hau" };

            IEnumerable<string> subset = from g in fruits
                                         where g.Contains(" ")
                                         orderby g
                                         select g;
            foreach (string s in subset)
                   Console.WriteLine("Item: {0}", s);
            */


            // slide 15
            /*
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            IEnumerable<int> query = nums.Where(n => n % 2 == 0);
            foreach (var n in query)
            {
                Console.WriteLine("{0}", n);
             }
             */

            /*
            //slide 19
            List<Car> myCars = new List<Car>()
            {
                new Car{ PetName = "Xe1", Color = "Bac", Speed = 100, Make = "BMW"},
                new Car{ PetName = "Xe2", Color = "Đen", Speed = 55, Make = "Toyota"},
                new Car{ PetName = "Xe3", Color = "Xanh", Speed = 5, Make = "Honda"},
                new Car{ PetName = "X4", Color = "Trang", Speed = 43, Make = "Ford"}

            };
            
            // lấy ra xe có tốc độ > 50  ( đang bị lỗi )
            IEnumerable<Car> subset = from c in myCars
                                      where c.Speed > 50
                                      select c;
            Console.WriteLine(" ------CACH 1----------");
            foreach (var c in subset)
            {
                Console.WriteLine(" - Car: {0} - {1} - {2} - {3} ", c.PetName, 
                    c.Color, c.Speed, c.Make);
            }


            IEnumerable<Car> subset2 = myCars.Where(c => c.Speed > 50);
            Console.WriteLine(" ------CACH 2----------");
            foreach (var c in subset2)
            {
                Console.WriteLine(" - Car: {0} - {1} - {2} - {3} ", c.PetName, c.Color, c.Speed, c.Make);
            }
            
            */

            /*
            //slide 22,23,24
            Categories[] categories = new[]
            {
             new Categories {CategoryId = 1, CategoryName = "Nuoc ngot" },
             new Categories {CategoryId = 2, CategoryName = "Van phong pham" },
             new Categories {CategoryId = 3, CategoryName = "Thuc pham" }
            };
            Products[] products = new[]
             {
             new Products {ProductId = 11, ProductName = "Pepsi", NumberInStock = 10, CategoryId = 1 },
             new Products {ProductId = 12, ProductName = "Coca", NumberInStock = 20, CategoryId = 1 },
             new Products {ProductId = 21, ProductName = "But bi", NumberInStock = 100, CategoryId = 2 },
              };

            //23
            var allProducts = from p in products
                              select p;

            foreach (var p in allProducts)
            {
                Console.WriteLine(p.ToString());
            }
            var cate2 = from p in products
                        where p.CategoryId == 2
                        select p;
            Console.WriteLine(" -- Cac sp có CategoryID=2 ----");
            foreach (var p in cate2)
            {
                Console.WriteLine(p.ToString());
            }
            //24
            var nameDesc = from p in products
                           select new
                           {
                               p.ProductId,
                               p.ProductName
                           };
            Console.WriteLine(" -- SLIDE 24 là cach 1 of nameDesc----");
            foreach (var p in nameDesc)
            {
                Console.WriteLine(p.ToString());
            }

            var nameDesc2= products.Select(p => new { p.ProductId, p.ProductName });
            Console.WriteLine(" -- SLIDE 25 là cach 2 of nameDesc ----");
            foreach (var p in nameDesc2)
            {
                Console.WriteLine(p.ToString());
            }

            //Slide 26
            var overstock = from p in products
                            where p.NumberInStock > 25
                            select p;
            Console.WriteLine(" -- SLIDE 26 là cach 1 cua overstock----");
            foreach (var p in overstock)
            {
                Console.WriteLine(p.ToString());
            }
            // slide 27
            var overstock2 = products.Where(p => p.NumberInStock > 25);
            Console.WriteLine(" -- SLIDE 27 là cach 2 cua overstock----");
            foreach (var p in overstock2)
            {
                Console.WriteLine(p.ToString());
            }
            */

            /*
                        //Slide 28
                        ArrayList myStuff = new ArrayList();// các phần tử bên trong kiểu nao cũng đc
                        myStuff.AddRange(new object[] { 10, 400, 8, false, new Car(), "string data" });
                        var myInts = myStuff.OfType<int>();  //lấy kiểu int thoi 

                        // Prints out 10, 400, and 8.
                        foreach (int i in myInts)
                        {
                            Console.WriteLine("Int value: {0}", i);
                        }
            */
            /*
            //slide 29
            ArrayList myCars = new ArrayList()
            {
               new Car{ PetName = "Xe1", Color = "Bạc", Speed = 100, Make = "BMW"},
               new Car{ PetName = "Xe2", Color = "Đen", Speed = 55, Make = "Toyota"},
              new Car{ PetName = "Xe3", Color = "Xanh", Speed = 5, Make = "Honda"},
               new Car{ PetName = "X4", Color = "Trắng", Speed = 43, Make = "Ford"}
             };
            var myCarsEnum = myCars.OfType<Car>();
            var fastCars = from c in myCarsEnum
                           where c.Speed > 55
                           select c;
            foreach (var c in fastCars)
            {
                Console.WriteLine("{0} is going too fast!", c.PetName);
            }
            */

            /*
            // slide 30   order by 
            Products[] products = new[]
             {
             new Products {ProductId = 11, ProductName = "Pepsi", NumberInStock = 10, CategoryId = 1 },
             new Products {ProductId = 12, ProductName = "Coca", NumberInStock = 20, CategoryId = 1 },
             new Products {ProductId = 21, ProductName = "But bi", NumberInStock = 100, CategoryId = 2 },
              new Products {ProductId = 23, ProductName = "But chi", NumberInStock = 50, CategoryId = 2 },
             new Products {ProductId = 24, ProductName = "But muc", NumberInStock = 15, CategoryId = 2 },};
            var subset = from p in products
                         orderby p.ProductName 
                          select p;

            Console.WriteLine("Ordered by Name cach 1:");
            foreach (var p in subset)
            {
                Console.WriteLine(p.ToString());
            }

            // slide 31
            var subset2 = products.OrderBy(p => p.ProductName);
            products.OrderByDescending(p => p.ProductName);
            Console.WriteLine("Ordered by Name cach 1:");
            foreach (var p in subset2)
            {
                Console.WriteLine(p.ToString());
            }
            */
            /*
            //slide  32
            Products[] products = new[]
             {
             new Products {ProductId = 11, ProductName = "Pepsi", NumberInStock = 10, CategoryId = 1 },
             new Products {ProductId = 12, ProductName = "Coca", NumberInStock = 20, CategoryId = 1 },
             new Products {ProductId = 21, ProductName = "But bi", NumberInStock = 100, CategoryId = 2 },
             new Products {ProductId = 23, ProductName = "But chi", NumberInStock = 50, CategoryId = 2 },
             new Products {ProductId = 24, ProductName = "But muc", NumberInStock = 15, CategoryId = 2 },};
            var subset = products.OrderBy(p => p.ProductName).ThenBy(p => p.ProductId);
            Console.WriteLine("Ordered by Name, ID - Cach 2:");
            foreach (var p in subset)
            {
                Console.WriteLine(p.ToString());

            }
            // sắp xếp theo CategoryID ,NumberInStock tăng dần 
            var subset2 = products.OrderBy(p => p.CategoryId).ThenBy(p => p.NumberInStock);
            Console.WriteLine("Ordered by ID, Stock - Cach 2:");
            foreach (var p in subset2)
            {
                Console.WriteLine(p.ToString());

            }
            */
            /*
            //slide 33 
            Products[] products = new[]
            {
             new Products {ProductId = 11, ProductName = "Pepsi", NumberInStock = 10, CategoryId = 1 },
             new Products {ProductId = 12, ProductName = "Coca", NumberInStock = 20, CategoryId = 1 },
             new Products {ProductId = 21, ProductName = "But bi", NumberInStock = 100, CategoryId = 2 },
             new Products {ProductId = 23, ProductName = "But chi", NumberInStock = 50, CategoryId = 2 },
             new Products {ProductId = 24, ProductName = "But muc", NumberInStock = 15, CategoryId = 2 },};
            var query = from p in products
                       group p by p.CategoryId;
           
            Console.WriteLine("---Groupby Category Cach 1 ----");
            foreach (var category in query)
            {
                Console.WriteLine("CategoryId: {0}", category.Key);
                foreach (var item in category)  // var thay cho product cũng đc
                {
                    Console.WriteLine(item.ToString());
                }
            }
            //slide 34
            var query2 = products.GroupBy(p => p.CategoryId);
            Console.WriteLine("\n ---Groupby Category Cach 2 ----"); 
            foreach (var category in query2)
            {
                Console.WriteLine("CategoryId: {0}", category.Key);
                foreach (Products item in category)
                {
                    Console.WriteLine(item);
                }
            }
            */
            /*
            //slide 35 
            Products[] products = new[]
            {
             new Products {ProductId = 11, ProductName = "Pepsi", NumberInStock = 10, CategoryId = 1 },
             new Products {ProductId = 12, ProductName = "Coca", NumberInStock = 20, CategoryId = 1 },
             new Products {ProductId = 21, ProductName = "But bi", NumberInStock = 100, CategoryId = 2 },
             new Products {ProductId = 23, ProductName = "But chi", NumberInStock = 50, CategoryId = 2 },
             new Products {ProductId = 24, ProductName = "But muc", NumberInStock = 15, CategoryId = 2 },};
            Categories[] categories = new[]
            {
             new Categories {CategoryId = 1, CategoryName = "Nuoc ngot" },
             new Categories {CategoryId = 2, CategoryName = "Van phong pham" },
             new Categories {CategoryId = 3, CategoryName = "Thuc pham" }
            };
            var query = from p in products
                        join c in categories
                        on p.CategoryId equals c.CategoryId
                        group p by new
                        {
                            c.CategoryId,
                            c.CategoryName
                        };
            foreach (var category in query)
            {
                Console.WriteLine(category.Key);
                foreach(var item in category)
                {
                    Console.WriteLine(item);
                }    
            }

            */



        }
    }
}

