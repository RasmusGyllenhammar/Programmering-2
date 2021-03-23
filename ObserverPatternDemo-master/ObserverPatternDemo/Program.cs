using System;

namespace ObserverPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject rasmusChannel = new Subject();

            Observer observer1 = new Observer("Observer 1");
            rasmusChannel.Subscribe(observer1);

            Observer observer2 = new Observer("Observer 2");
            rasmusChannel.Subscribe(observer2);

            rasmusChannel.Inventory++;

            Observer observer3 = new Observer("Observer 3");
            rasmusChannel.Subscribe(observer3);

            rasmusChannel.Inventory++;



            Console.ReadLine();
        }
    }
}
