using System;
using System.Linq;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello methods!");

            int[] array = { 10, 10, 12 };

            Console.WriteLine(MetodOne(array));

            //för metod 2
            String[] names = { "JALLAJ", "BISMIHALLA", "ALHAMDULILLAH" };

            Console.WriteLine(MetodTwo(names));
            
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
        public static String[] MetodTwo(string[] words)
        {


            

            for(int i = 0; i < words.Length / 2; i++) // delar med två för att den inte ska gå igenom igen så listan blir i samma ordning
            {
               
                
                
                var temp = words[i];
                words[i] = words[words.Length - i - 1];
                words[words.Length - i - 1] = temp;

                
            }

            foreach(String name in words) // ska skriva ut orden i bakvänd ordning
            {
                Console.WriteLine(name);
            }
            
            return words;
        }
    }
}
