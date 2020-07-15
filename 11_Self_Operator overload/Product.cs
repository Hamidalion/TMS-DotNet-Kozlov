using System;

namespace _11_Self_Operator_overload
{
    public abstract class Product
    {
        public string Name { get;}

        public int Colories { get;}

        public int Volume { get; set; }

        public double totalColories
        {
            get
            {
                return Volume / 100 * Colories;
            }
        }

        public Product(string name, int colories, int volume) // конструктор
        {
            if (string.IsNullOrWhiteSpace (name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (colories < 0)
            {
                throw new ArgumentException(nameof(colories));
            }

            if (volume <= 0)
            {
                throw new ArgumentException(nameof(volume));
            }

            Name = name;
            Colories = colories;
            Volume = volume; 

        }

        public override string ToString()
        {
            return $"{Name} - {Volume}: {Colories}"; 
        }
    }
}
