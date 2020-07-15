using System;
using System.Text.RegularExpressions;

namespace _11_Self_Operator_overload
{
    public class Apple : Product // унаследовали от продукта
    {
        public Apple(string name, int colories, int volume) : base(name, colories, volume)
        {

        }

        public static Apple Add(Apple apple1, Apple apple2 )
        {
            var colories = (int)Math.Round(((apple1.Colories + apple2.Colories) / 2.0));
            var volume = apple1.Volume + apple2.Volume;
            var apple = new Apple("Яблоко", colories, volume);

            return apple;
        }

        public static Apple operator + (Apple apple1, Apple apple2)
        {
            var colories = (int)Math.Round(((apple1.Colories + apple2.Colories) / 2.0));
            var volume = apple1.Volume + apple2.Volume;
            var apple = new Apple("Яблоко", colories, volume);

            return apple;
        }
        public static Apple operator + (Apple apple1, int volume)
        {
            var apple = new Apple("Яблоко", apple1.Colories, apple1.Volume + volume);
            return apple;
        }


    }
}
