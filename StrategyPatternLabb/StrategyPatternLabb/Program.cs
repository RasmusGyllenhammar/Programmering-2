using System;

namespace StrategyPatternLabb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type d,c, k or l to get an animal sound");

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
                    animalSound.animalScreech();
                    break;

                case "l":
                    animalSound = new Cow();
                    animalSound.animalScreech();
                    break;
                 

            }
            Console.WriteLine("You butcher da animal? meat meat meat");

            

        }

        
    }
}
