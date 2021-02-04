using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternLabb
{
    class ButcherAnimal : IAnimal
    {
        public void animalScreech()
        {
            Console.WriteLine("bom animal no sound, ded");
            Console.WriteLine("5 piecies");
            
        }


    }
}
