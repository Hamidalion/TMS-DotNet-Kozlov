using System;
using System.Collections.Generic;
using System.Text;
using ZooHomework.Interfaces;
using ZooHomework.Models;

namespace ZooHomework.Logic
{
    class AnimalAction : IAnimalAction
    {
        public void GetInfo(Animal animal)
        {
            Console.WriteLine($"ID; {animal.GetId()}");
            Console.WriteLine($"Name; {animal.Name}");
            Console.WriteLine($"Kind; {animal.Kind}");
            Console.WriteLine($"Passport; {animal.GetPassport()}");
        }

        public void Rename(Animal animal, string name)
        {
            animal.Name = name;
        }

        public void SetPassport(Animal animal, string passport)
        {
            animal.SetPassport(passport);
        }
    }
}
