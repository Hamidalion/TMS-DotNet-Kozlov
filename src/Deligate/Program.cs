using System;

namespace Deligate
{
    //public delegate тип_возвращаемого_значения имя_делегата (тип_аргкмента аргумент)
    //объявление делегата
    public delegate void MyDelegate();



    class Program
    {
        public delegate int ValueDelegate(int i);

        


        static void Main(string[] args)
        {
            
            // первый вариант вызова
            MyDelegate myDelegate = Method1;
            myDelegate += Method4;
            myDelegate();
            Console.WriteLine();

            // второй вариант и более правильный
            MyDelegate myDelegate2 = new MyDelegate(Method4);
            myDelegate2 += Method1;
            myDelegate2.Invoke();
            Console.WriteLine();

            //сложение делегатов
            MyDelegate myDelegate3 = myDelegate + myDelegate2;
            myDelegate3.Invoke();
            Console.WriteLine();

            //объявляем делегат
            var valueDelegate = new ValueDelegate(MethodValue);
            valueDelegate(new Random().Next(10,80));

            //шаблонный (сделанный за нас) делегат
            Action Name = Method1;
            Name.Invoke();



            Console.ReadLine();
        }

        public static int MethodValue(int i)
        {
            Console.WriteLine(i);
            return i;
        }


        public static void Method1()
        {
            Console.WriteLine("Hello Method1");
        }

        public static int Method2()
        {
            Console.WriteLine("Hello Method2");
            return 0;
        }

        public static int Method3(int r)
        {
            Console.WriteLine(r);
            return r;
        }

        public static void Method4()
        {
            Console.WriteLine("Hello Method4");
        }
    }
}
