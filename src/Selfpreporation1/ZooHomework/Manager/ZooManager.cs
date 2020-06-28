using System;
using System.Collections.Generic;
using System.Text;
using ZooHomework.Enums;
using ZooHomework.Models;

namespace ZooHomework.Manager
{
    class ZooManager
    {
        private readonly AnimalAction _animalManager;
        
        public List<Animal> animals = new List<Animal>();

        public ZooManager()
        {
            _animalManager = new AnimalAction();
        }

        public void GetAnimal(Animal animal)
        {
            _animalManager.GetInfo(animal);
        }

        public void GetAllAnimal()
        {
            if (animals.Count > 0)
            {
                foreach (var animal in animals)
                {
                    _animalManager.GetInfo(animal);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Животных нет");
                Console.ForegroundColor = ConsoleColor.White;
            }

        }

        public void SetAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        public void RemoveAnimal(Animal animal)
        {
            animals.Remove(animal);
        }

        public Animal CreateAnimal()
        {
            return new Animal();
        }
        public Animal CreateAnimal(string name)
        {
            return new Animal(name);
        }
        public Animal CreateAnimal(string name, KindType kind)
        {
            return new Animal(name, kind);
        }
        public Animal CreateAnimal(string name, KindType kind, string passport)
        {
            return new Animal(name, kind, passport);
        }
    }
}
