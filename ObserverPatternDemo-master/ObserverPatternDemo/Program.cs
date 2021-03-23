using System;

namespace ObserverPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Channel rasmusChannel = new Channel();

            Subscribers observer1 = new Subscribers("KUngen Rasmus");
            rasmusChannel.Subscribe(observer1);

            Subscribers observer2 = new Subscribers(" King Haris");
            rasmusChannel.Subscribe(observer2);

            rasmusChannel.Inventory++; //fler videos jaoo

            Subscribers observer3 = new Subscribers("Kung Oskaroru"); //oskar subscriba king
            rasmusChannel.Subscribe(observer3);

            rasmusChannel.Inventory++;



            Console.ReadLine();
        }
    }
}
