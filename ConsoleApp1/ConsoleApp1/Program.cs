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
        static Customer sadio = new Customer();
        static void Main(string[] args)
        {


            
            MenuForCars();

            
        }
      
        static void MenuForCars()
        {
            Console.WriteLine("what cars do you want? Pick any car/cars you like");
            Console.WriteLine("(1) volvo v40 cc" + "\n" +
          
                              "(2) volvo v60" + "\n" +
                            
                              "(3) volvo polestar(BEST SELLER)" + "\n" +
                            
                              "(4) finished no more cars yo");
           
           
            
            bool buy = false;
           
            while (!buy) {
                int volvoCars = Convert.ToInt32(Console.ReadLine());
                switch (volvoCars)
            {
                case 1:
                    Console.WriteLine("volvo v40 cc added");
                    coolCar.CarName = "volvo v40 cc";
                    sadio.shoppingCart.Add(coolCar);  
                    continue;

                case 2:
                        Console.WriteLine("volvo v60 added");
                        coolCar.CarName = "volvo v60";
                        sadio.shoppingCart.Add(coolCar);
                        continue;

                    case 3:
                        Console.WriteLine("volvo polestar added");
                        coolCar.CarName = "volvo polestar";
                        sadio.shoppingCart.Add(coolCar);
                       
                        continue;
                    case 4:
                        Console.WriteLine("Ok you done shopping");
                        Console.WriteLine("You have bought " + sadio.shoppingCart.Count + "items");
                        break;

                    

                
                
                
            }
            }


            
        }
    }
}
