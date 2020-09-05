using System;

namespace _9_Self_Class_Constr_Prop
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "Mike";
            p.SecondName = "Bond";


            Console.WriteLine(p.FullName);
            Console.WriteLine(p.Short);

            Console.ReadLine();
        }
    }
}
