using System;
using System.Collections.Generic;
using System.Text;

namespace abstractLabb
{
    class Rolex : Accesories
    {
      public Rolex()
        {
            HourHand = 7;
            Color = "purple";
        }


        //beteenden
        public override void expensive()
        {
            Console.WriteLine("IT IS VERY EXPENSIVE 200");
        }

        public override void shiny()
        {
            Console.WriteLine("bling bling");
        }
    }
}
