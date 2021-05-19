using System;

namespace FoodDecider
{
    class Program
    {
        static void Main(string[] args)
        {
            Random foodGen = new Random();
            int roll = foodGen.Next(1, 7);
            if(roll == 1)
            {
                Console.WriteLine("Pizza");
            }
            if(roll == 2)
            {
                Console.WriteLine("Mexican");
            }
            if(roll == 3)
            {
                Console.WriteLine("SkyLine Chili");
            }
            if(roll == 4)
            {
                Console.WriteLine("Chinese");
            }
            if(roll == 5)
            {
                Console.WriteLine("Subs");
            }
            if(roll == 6)
            {
                Console.WriteLine("Indian/Thai");
            }
        }
    }
}
