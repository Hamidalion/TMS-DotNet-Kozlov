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
            //int Monday = 1, Tuesday = 2, Wednesday = 3, Thursday = 4, Friday = 5, Saturday = 6, Sunday = 7;
            int Monday = 1, Tuesday = 2, Wednesday = 3, Thursday = 4, Friday = 5, Saturday = 6, Sunday = 7;

            Console.WriteLine("Now is");
            Console.Write(DateTime.UtcNow); Console.WriteLine("(UTC)"); 
            Console.WriteLine(DateTime.Now);
            DateTime week = DateTime.Now;
            Console.WriteLine(week.DayOfWeek);

            Console.WriteLine("Select your favorite day of the week");
            Console.WriteLine("Monday-1,Tuesday-2,Wednesday-3,Thursday-4,Friday-5,Saturday-6,Sunday-7");
            
            int a = Convert.ToInt32(Console.ReadLine());
          
            if (a == 1)
            {
                Console.WriteLine("your favorite day of the week is Mondey and you are crazy");

            }
            else
            {
                Console.WriteLine($"Nomber {a} is odd");
            }




            //Console.WriteLine("You choose", 1 = Monday, 
            
                
                
                
            //Console.WriteLine($"Hello {enum}");
            //DayOfWeek op;
            //op = DayOfWeek.Add;



            Console.ReadKey();
        }
    }
}
