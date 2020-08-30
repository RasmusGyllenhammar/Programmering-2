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
            
            Console.WriteLine("write your name, your age and type 'yes to be alive or write 'no' to be ghost");

            String userName = Console.ReadLine();

            int inputAge = Convert.ToInt32(Console.ReadLine());
           

                 yesOrNo = Console.ReadLine();
                
                if(yesOrNo == "yes")
                {
                    Console.WriteLine("omg you ARE ALIVE");
                }
                else if(yesOrNo == "no")
                {
                    Console.WriteLine("OH LORD JESUS YOU ARE DED");
                    
                }

            Console.WriteLine("Your name is " + userName);

            Console.Write(Environment.NewLine);

            Console.WriteLine("oh too young, yet too old " + inputAge);


























        }
    }
}
