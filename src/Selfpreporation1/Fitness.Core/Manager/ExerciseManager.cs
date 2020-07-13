using Fitness.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fitness.Core.Manager
{
    public class ExerciseManager : IExerciseManager
    {
        public double Jump(int count, double weight, int age) => count * weight * age * 0.24;

        public double Run(double distance, double height, double weight, int age) => distance * weight * height * age * 0.33;

        public double Sweem(double distance, double height, double weight, int age) => distance * weight * height * age * 0.43;
    }
}
