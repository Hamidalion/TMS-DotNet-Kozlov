using System;

namespace ToDo
{
    partial class Program
    {
        static void Main()
        {
            Console.WriteLine("Inter your first task");
            var todo1 = new ToDo(DateTime.Now)
            {
                Name = Console.ReadLine()
            };
           
            Console.WriteLine(DateTime.Now.AddHours(3));

            Console.WriteLine("Inter your second task");
            var todo2 = new ToDo(DateTime.Now)
            {
                Name = Console.ReadLine()
            };

            todo1.Show();

            todo2.Show();

            Console.ReadKey();
      
        }
    }
}
