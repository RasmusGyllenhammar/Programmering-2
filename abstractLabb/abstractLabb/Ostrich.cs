using System;
using System.Collections.Generic;
using System.Text;

namespace abstractLabb
{
    class Ostrich : Animal
    {
        // initalize
        public Ostrich()
        {
            NumberOfEyes = 20;
            Color = "blue";
        }
        public override void eat()
        {
            Console.WriteLine("SHOOTS HIS HEAD INTO THE GROUND");
        }

        public override void sleep()
        {
            Console.WriteLine("THEY DONT SLEEP");
        }
    }
}
