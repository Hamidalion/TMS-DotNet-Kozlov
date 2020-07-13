using System;
using System.Collections.Generic;
using System.Text;
using Fitness.Core.Manager;
using System.Linq;

namespace Fitness.Core.Interfaces
{
    public interface IExerciseManager
    {
        double Jump(int count, double weight, int age);
        double Run(double distance, double height, double weight, int age);
        double Sweem(double distance, double height, double weight, int age);
    }
}
