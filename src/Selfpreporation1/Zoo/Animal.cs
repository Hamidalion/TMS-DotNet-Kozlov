using System;

namespace Zoo
{
    partial class Program
    {
        public class Animal
        {
            public Animal()
            {
            }

            public Animal(string name)
            {
                Name = name;
            }

            public string Name { get; set; }

            public string Kind { get; set; }

            public bool Gender { get; set; }

            public void Say { get; set; }

            Console.WriteLine("what can i say");
        }
    }
}
