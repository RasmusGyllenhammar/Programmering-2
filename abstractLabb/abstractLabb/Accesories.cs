using System;
using System.Collections.Generic;
using System.Text;

namespace abstractLabb
{
   abstract class Accesories
    {   
        //egenskaper
        public int HourHand { get; set; }

        public string Color { get; set; }


        //Beteenden lol
        public abstract void shiny();

        public abstract void expensive();
    }
}
