using System;
using System.Collections.Generic;
using System.Text;

namespace abstractLabb
{
   abstract class Animal
    {

        public int NumberOfEyes { get; set; }

        public string Color { get; set; }


        //beteenden
        public abstract void sleep();

        public abstract void eat();

    }
}
