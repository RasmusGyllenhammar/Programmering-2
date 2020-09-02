using System;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Niklas!");

            string yesOrNo = "";
            
            Console.WriteLine("write your age, type 'yes to be alive or write 'no' to be ghost and do not forget your name ");

           

            var inputAge = Convert.ToInt32(Console.ReadLine());

            switch (inputAge)
            {
                case 15:
                    Console.WriteLine("MADT only 15");
                    break;
                case 16:
                    Console.WriteLine("sweet 16 EYYYY");
                    break;
                case 17:
                    Console.WriteLine("omg SOON 18 O:");
                    break;

                case 18:
                    Console.WriteLine("omg 18 you can get driver license");
                    break;

                default:
                    Console.WriteLine("that age is very unusual huh " + inputAge);
                    break;
            }

   





           
            var questionToBeAlive = true;
            while (questionToBeAlive)
            { yesOrNo = Console.ReadLine();
                if (yesOrNo == "yes")
                {
                    Console.WriteLine("omg you ARE ALIVE");
                    break;
                }
                else if (yesOrNo == "no")
                {
                    Console.WriteLine("OH LORD JESUS YOU ARE DED");
                    break;

                }
                else
                {
                    Console.WriteLine("are you alive or dead?");
                    continue;
                }
            }
               
            
            
            var test = true;
            while (test)
            {
                String userName = Console.ReadLine();
                if (userName == "rasmus")
                {
                    Console.WriteLine("Omg u are " + userName);
                    break;
                }else if(userName == "niklas")
                {
                    Console.WriteLine("omg u is " + userName);
                    break;
                }
                else
                {
                    Console.WriteLine("omg not right");
                    continue;
                }

            }
            

           

            


























        }
    }
}
