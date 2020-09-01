using System;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Niklas!");

            string yesOrNo = "";

            bool alive = true;
            
            Console.WriteLine("write your age, type 'yes to be alive or write 'no' to be ghost and do not forget your name ");

           

            var inputAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("oh too young, yet too old " + inputAge);


            yesOrNo = Console.ReadLine();
                
                if(yesOrNo == "yes")
                {
                    Console.WriteLine("omg you ARE ALIVE");
                }
                else if(yesOrNo == "no")
                {
                    Console.WriteLine("OH LORD JESUS YOU ARE DED");
                    
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
