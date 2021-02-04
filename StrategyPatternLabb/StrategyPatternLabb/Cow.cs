using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternLabb
{
    class Cow : IAnimal
    {
        public void animalScreech()
        {
           Console.WriteLine("MOOOOOOOO MOOOOO MOOOO KOSSA COW");
        }
    }
}
