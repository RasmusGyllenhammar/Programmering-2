using System;
using System.Collections.Generic;
using System.Text;

namespace abstractLabb
{
    class Pig : Animal
    {       
            //En instructor, initalize the objects
           public Pig()
        {
            NumberOfEyes = 1;
            Color = "black";
        }
        public override void eat()
        {
            Console.WriteLine("PIg NONOMNOM");
        }

        public override void sleep()
        {
            Console.WriteLine(" PIG I SLEEp");
        }
    }
}
