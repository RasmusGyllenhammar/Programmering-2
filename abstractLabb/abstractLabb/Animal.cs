using System;
using System.Collections.Generic;
using System.Text;

namespace abstractLabb
{
   abstract class Animal
    {
        // initalize D
        public int NumberOfEyes { get; set; }

        public string Color { get; set; }


        //beteenden ha detta i interface,
        public abstract void sleep();

        public abstract void eat();

    }
}
