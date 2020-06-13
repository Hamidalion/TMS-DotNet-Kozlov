using System;

namespace SelfPreporation1
{
    class Program
    {
        enum DayOfWeek
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            //int monday = 1;
            //int tuesday = 2;
            //int Saturday = 2


            Console.WriteLine("Now is");
            Console.Write(DateTime.UtcNow); Console.WriteLine("(UTC)"); 
            Console.WriteLine(DateTime.Now);
            DateTime week = DateTime.Now;
            Console.WriteLine(week.DayOfWeek);
            Console.WriteLine("Select your favorite day of the week");
            Console.WriteLine("Monday-1,Tuesday-2,Wednesday-3,Thursday-4,Friday-5,Saturday-6,Sunday-7");
            Console.ReadLine();
            
            Console.ReadKey();
        }
    }
}
