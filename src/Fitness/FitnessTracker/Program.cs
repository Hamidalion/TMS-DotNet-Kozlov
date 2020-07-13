using Fitness.Core.Interfaces;
using Fitness.Core.Manager;
using System;
using System.Reflection.Metadata;

namespace FitnessTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonManager personManager = new PersonManager();
            IExerciseManager exerciseManager = new ExerciseManager();

            personManager.CreateUsers("Nick", 15, 40, 100);
            var run = exerciseManager.Run(10, 100, 40, 15);


            Console.ReadKey();
        }
    }
                        


}
