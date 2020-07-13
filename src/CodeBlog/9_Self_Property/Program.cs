using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Person p = new Person();

            //p.SetName ("Вася");
            p.Name = ("Вася");
            p.SecondName = ("Пупкин ");

            //Console.WriteLine(p.GetName());
            Console.WriteLine(p.Name);
            Console.WriteLine(p.FullName);
            Console.WriteLine(p.ShotName);


            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
