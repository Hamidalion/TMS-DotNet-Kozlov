using System;
using System.Collections.Generic;
using System.Text;
using ZooHomework.Manager;
using ZooHomework.Models;

namespace ZooHomework
{
    class Program
    {
        private static readonly AnimalAction _animalManager = new AnimalAction();
        private static readonly ZooManager _zoo = new ZooManager();
        static void Main(string[] args)
        {                    
            while (true)
            {
                ShowMenu();
                int.TryParse(Console.ReadLine(), out int UserInput);
                    switch (UserInput)
                    {
                        case 1:
                            {
                            InputAnimal();
                            }
                            break;

                        case 2:
                            {

                            }
                            break;

                        case 3:
                            {
                                Console.WriteLine("Данный функционал не реализован");
                            }
                            break;

                        case 4 :
                            {
                                _zoo.GetAllAnimal();
                            }
                            break;

                        case 5:
                            {
                                Environment.Exit(0);
                            }
                            break;

                        default:
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Команда не найдена");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            break;
                    }
                Console.WriteLine();
            }

        }

        private static void InputAnimal()
        {
            Console.Write("Введите имя:");
            var name = Console.ReadLine();

            Animal animal;

            if (!string.IsNullOrEmpty(name))
            {
                animal = _animalManager.CreateAnimal(name);
            }
            else
            {
                animal = _animalManager.CreateAnimal();
            }
            _zoo.SetAnimal(animal);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Животное успешно создано и добавлено в зоопарк");
            Console.ForegroundColor = ConsoleColor.White;

            //Console.Write("Введите тип животного\n");
        }

        private static void ShowMenu()
        {
            Console.WriteLine("Выберите действие");
            Console.WriteLine("1. Добавить животное");
            Console.WriteLine("2. Удалить животное");
            Console.WriteLine("3. Паказать животное");
            Console.WriteLine("4. Показать всех животных");
            Console.WriteLine("5. Выход");
            Console.WriteLine();
        }
    }
}
