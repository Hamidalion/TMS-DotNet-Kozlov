using System;

namespace _11_Self_Operator_overload
{
    class Program
    {
        static void Main()
        {
            Apple apple1 = new Apple("Антоновка", 150, 100);
            Apple apple2 = new Apple("Дичка", 80, 110);

            var summApple = Apple.Add(apple1, apple2);

            var summApple2 = apple1 + apple2;

            var summApple3 = apple1 + 100;

            Console.WriteLine(apple1);
            Console.WriteLine(apple2);
            Console.WriteLine(summApple);
            Console.WriteLine(summApple2);
            Console.WriteLine(summApple3);

            Console.ReadLine(); ;
        }
        
    }
}
