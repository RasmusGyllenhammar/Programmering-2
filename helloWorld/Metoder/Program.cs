using System;
using System.Linq;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
            Console.WriteLine("Hello methods!");

            int[] array = { 10, 10, 12 };

            Console.WriteLine(MetodOne(array));

            //för metod 2
            String[] names = { "JALLAJ", "BISMIHALLA", "ALHAMDULILLAH" };

            //Console.WriteLine(MetodTwo(names)); fel här nu när det är void
            */
            //för metod 3
            int[] listaMetodTree = {2, 15, 20};

           Console.WriteLine(MetodTre(listaMetodTree));
           
            
        }

        public static int MetodOne(int[] listaMedTal)
        {
            var sum = 0;

            for(int i = 0; i <= listaMedTal.Length -1; i++)
            {
                sum += listaMedTal[i];
            }
            
            return sum;
        }
        public static void MetodTwo(string[] words)
        {


            

            for(int i = 0; i < words.Length / 2; i++) // delar med två för att den inte ska gå igenom igen så listan blir i samma ordning, här vänder man på listan
            {
               
                var temp = words[i];
                words[i] = words[words.Length - i - 1];
                words[words.Length - i - 1] = temp; 

                
            }

            foreach(String name in words) // ska skriva ut orden fast i bakvänd ordning nu
            {
                Console.WriteLine(name);
            }
            
            
        }
        public static (int,int) MetodTre(int[] findBigNumberAndLow)
        {   



           var lowestNumber = findBigNumberAndLow.Min(); // kollar efter minsta värdet 
            var greatestNumber = findBigNumberAndLow.Max(); // hittar upp största värdet
           

           
            return (lowestNumber, greatestNumber);
        }
    }
}
