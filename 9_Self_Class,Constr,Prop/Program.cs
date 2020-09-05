using System;

namespace _9_Self_Class_Constr_Prop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Intere Name");
            var name = Console.ReadLine();
            Console.WriteLine("Inter age");
            var age = int.Parse( Console.ReadLine());

            Person p = new Person(name, "Potter", age);
            //p.Name = "Mike";
            //p.SecondName = "Bond";


            Console.WriteLine(p.FullName + age);
            Console.WriteLine(p.Short);

            Console.ReadLine();
        }
    }
}
