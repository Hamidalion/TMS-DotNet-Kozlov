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
            IPersonManager parsonManager = new PersonManager();

            parsonManager.CreateUsers("Nick", 15, 40, 100);


            Console.ReadKey();
        }
    }
                        


}
