using OOP;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;

namespace ConsoleApp1
{
    class Program
    {
        static product coolCar = new product();


        static ProductOne volvo = new ProductOne();
        static Customer sadio = new Customer();
        static productTwo bmw = new productTwo();
        static ProductThree kia = new ProductThree();
        static void Main(string[] args)
        {
            NewCustomer();
            MenuForCars();
           

        }

        static void Orders()
        {
            Console.WriteLine(sadio._name + ", You have ordered " + sadio._shoppingCart.Count + " items: ");

            foreach (var item in sadio._shoppingCart)
            {
                Console.WriteLine(item.CarName);
            }; 
           
            Environment.Exit(0);
        }
        static void NewCustomer()
        {
            Console.WriteLine("hello new customer, what is your name?");
            sadio._name = Console.ReadLine();
        }
        static void MenuForCars()
        {
            Console.WriteLine(sadio._name + " what cars do you want? Pick any car/cars you like");
            Console.WriteLine("(1) volvo v40 cc" + "\n" +

                              "(2) Bmw 1-serie" + "\n" +

                              "(3)Kia car " + "\n");
           
           
            
            bool buy = false;
           
            while (!buy) {
                var cars = Convert.ToInt32(Console.ReadLine());
                switch (cars)
            {
                case 1:
                    Console.WriteLine("volvo v40 cc added");
                    volvo.CarName = "volvo v40 cc";
                    sadio._shoppingCart.Add(volvo);  
                    continue;

                case 2:
                        Console.WriteLine(" Bmw 1-serie added");
                        bmw.CarName = "Bmw 1-serie";
                        sadio._shoppingCart.Add(bmw);
                        continue;

                    case 3:
                        Console.WriteLine("kia car added");
                        kia.CarName = "kia";
                        sadio._shoppingCart.Add(kia);
                        continue;
                    

                    case 9:
                        Console.WriteLine("Ok you done shopping");
                        Orders();
                        break;
                      

                    

                
                
                
            }
            }


            
        }
    }
}
