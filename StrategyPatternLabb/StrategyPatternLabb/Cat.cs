using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternLabb
{
    class Cat : IAnimal
    {
        public void animalScreech()
        {
            Console.WriteLine("CAT Goes Mjauuoowwwwwww");
        }
    }
}
