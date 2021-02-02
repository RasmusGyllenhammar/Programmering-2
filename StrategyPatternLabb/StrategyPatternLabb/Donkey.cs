using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternLabb
{
    class Donkey : IAnimal
    {
        public void animalScreech()
        {
            Console.WriteLine("DONKEY GOES VROOM VROOOOM");
        }
    }
}
