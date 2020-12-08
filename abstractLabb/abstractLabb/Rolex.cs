using System;
using System.Collections.Generic;
using System.Text;

namespace abstractLabb
{
    class Rolex : Accesories
    {
        public int HourHand { get; set; }

        public string Color { get; set; }

        //beteenden
        public override void expensive()
        {
            Console.WriteLine("IT IS VERY EXPENSIVE");
        }

        public override void shiny()
        {
            Console.WriteLine("");
        }
    }
}
