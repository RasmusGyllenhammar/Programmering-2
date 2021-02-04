using System;

namespace StrategyPatternLabb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type d,c or k to get an animal sound");

            IAnimal animalSound;
            var choice = Console.ReadLine().ToLower();
            switch (choice)
            {
                case "d":
                    animalSound= new Donkey();
                    animalSound.animalScreech();
                    break;
                case "c":
                    animalSound = new Camel();
                    animalSound.animalScreech();
                    break;
                case "k":
                    animalSound = new Cat();
                    break;
                 

            }
            

        }

        
    }
}
