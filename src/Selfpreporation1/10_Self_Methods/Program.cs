using Self;
using System;
using System.Xml;

namespace _10_Self_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //модификатор_доступа тип_возврощаемого_значения имя_метода (тип_фргумента1 имя_аргумента1, тип_фргумента2 имя_аргумента2)
            //{
            //}
            //var i =  PrintHello("Вадим", 27);
            var person1 = new Person("Иванов", "Иван");
            var person2 = new Person("Петров", "Петя");

            for (int i = 0; i < 10; i++)
            {
                var position1 = person1.Run();
                Console.WriteLine(position1);

                Console.WriteLine(person2.Run(1.4));
            }

            //Console.WriteLine(i);
            Console.WriteLine(Factorial(5));
            Console.ReadKey();
        }

        //РЕКУРСИЯ
        public static int Factorial (int value)
        {
            if (value <= 1)
            {
                return 1;
            }
            else
            {
                return value * Factorial(value - 1);
            }
        }

        //public static int PrintHello(string name, int age)
        //{
        //    Console.WriteLine($"Привет {name}. Вам {age} лет");
        //    return 1;
        //}

    }
}
