using System;

namespace MethodDayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            sysDate();
            choose();

            static void sysDate()
            {
                Console.WriteLine("Now is");
                Console.Write(DateTime.UtcNow); Console.WriteLine("(UTC)");
                Console.WriteLine(DateTime.Now);
                DateTime week = DateTime.Now;
                Console.WriteLine(week.DayOfWeek);
            }
            static void choose()
            {
                Console.WriteLine("Select your favorite day of the week");
                Console.WriteLine("1:Sunday,2:Monday,3:Tuesday,4:Wednesday,5:Thursday,6:Friday,7:Saturday");
               
                string[] chooseDay =new string[] { "Faild choose","Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        Console.WriteLine("You favorite day of the week is Sunday");
                        break;
                    case "2":
                        Console.WriteLine("You favorite day of the week is Monday");
                        break;
                    case "3":
                        Console.WriteLine("You favorite day of the week is Tuesday");
                        break;
                    case "4":
                        Console.WriteLine("You favorite day of the week is Wednesday");
                        break;
                    case "5":
                        Console.WriteLine("You favorite day of the week is Thursday");
                        break;
                    case "6":
                        Console.WriteLine("You favorite day of the week is Friday");
                        break;
                    case "7":
                        Console.WriteLine("You favorite day of the week is Saturday");
                        break;
                    default:
                        Console.WriteLine("You entered an invalid date");
                        break;
                }

                Console.ReadKey();
            }
        }
    }
}
