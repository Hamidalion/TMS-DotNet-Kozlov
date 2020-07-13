using System;
using System.Collections.Generic;
using System.Text;

namespace Fitness.Core.Interfaces
{
    public  interface IPersonManager
    {
        public void CreateUsers(string name, int age, double weights, double height);
    }
}
