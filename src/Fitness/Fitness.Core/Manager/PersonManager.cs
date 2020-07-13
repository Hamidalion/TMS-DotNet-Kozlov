using Fitness.Core.Enums;
using Fitness.Core.Interfaces;
using Fitness.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Fitness.Core.Manager
{
    public class PersonManager : IPersonManager
    {
        public readonly IList<Person> people;

        private readonly IExerciseManager _exerciseManager;

        public PersonManager()
        {
            people = new List<Person>();
            _exerciseManager = new ExerciseManager();
        }

        public void CreateUsers(string name, int age, double weights, double height)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Некорекные данные - name"); 
                return;
            }
            if (age>80 || age < 10)
            {
                Console.WriteLine("Некорекные данные - age");
                return;
            }
            if (weights > 300 || weights < 10)
            {
                Console.WriteLine("Некорекные данные - weights");
                return;
            }
            if (height > 300 || height < 10)
            {
                Console.WriteLine("Некорекные данные - height");
                return;
            }


            var person = new Person
            {
                Name = name,
                Age = age,
                Weights = weights,
                Height = height
            };

            people.Add(person);
        }

        public void DoExeJump(string id, int count, double weight, int age)
        {
            var person = people.FirstOrDefault(p => p.Id == id);
            if (person == null)
            {
                Console.WriteLine("Пользователь не найден");
                return;
            }

            var caloriesJump = _exerciseManager.Jump(count, person.Weights, person.Age);

            var result = new Result
            {
                Date = DateTime.Now,
                Type = ExerciseType.Jump,
                Colories = _exerciseManager.Jump(count, person.Weights, person.Age)
            };

            person.ColoriesPerDay.Add(result);
        }
        public void DoExeRun(string id, double distance, double height, double weight, int age)
            {
            var person = people.FirstOrDefault(p => p.Id == id);
            if (person == null)
            {
                Console.WriteLine("Пользователь не найден");
                return;
            }

            var caloriesRun = _exerciseManager.Run(distance, person.Height, person.Weights, person.Age);

            var result2 = new Result
            {
                Date = DateTime.Now,
                Type = ExerciseType.Run,
                Colories = _exerciseManager.Run(distance, person.Height, person.Weights, person.Age)
            };

            person.ColoriesPerDay.Add(result2);

        }

        public void GetStatistic(string id)
        {
            var person = people.FirstOrDefault(p => p.Id == id);
            if (person == null)
            {
                Console.WriteLine("Пользователь не найден");
                return;
            }

            foreach (var info in person.ColoriesPerDay)
            {
                Console.WriteLine($"Date: {info.Date}, Type: {info.Type}, Colories: {info.Colories}");
            }
        }
    }
}
