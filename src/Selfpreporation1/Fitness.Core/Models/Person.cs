using System;
using System.Collections.Generic;
using System.Text;

namespace Fitness.Core.Models
{
    public class Person
    {
        public string Id { get; } = Guid.NewGuid().ToString();

        public string Name { get; set; }

        public double Weights { get; set; }

        public double Height { get; set; }

        public int Age { get; set; }

        public IList<Result> ColoriesPerDay { get; set; } = new List<Result>();
    }
}
