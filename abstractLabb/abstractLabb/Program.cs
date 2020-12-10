using System;
using System.Collections.Generic;

namespace abstractLabb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //anropar konstruktorn på list
            List<Animal> animals = new List<Animal>();

            var elephant = new Elephant();
            elephant.Color = "red";

            var pig = new Pig();
            var ostrich = new Ostrich();

            //O:
            animals.Add(elephant);
            animals.Add(pig);
            animals.Add(ostrich);
           
            //anropar metoderna inom ANimal
            foreach (var beast in animals)
            {
                beast.eat();
                beast.sleep();
            }
        }
    }
}
