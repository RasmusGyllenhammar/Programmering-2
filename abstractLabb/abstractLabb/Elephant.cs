using System;
using System.Collections.Generic;
using System.Text;

namespace abstractLabb
{
    class Elephant : Animal
    {   
        public Elephant()
        {
            NumberOfEyes = 3;
            Color = "green";
        }
        public override void eat()
        {
            Console.WriteLine("ElEPHANT is eating peanut");
        }

        public override void sleep()
        {
            Console.WriteLine("SNORE SNORE SNORE ELEPHANT");
        }
    }
}
