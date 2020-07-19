using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace _17_Self_Asunc_Await__Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            #region thread
            //Thread thread1 = new Thread(new ThreadStart(DoWork)); // если нет в принимаемом методе оргументов (c параметром)
            //thread1.Start();

            //Thread thread2 = new Thread(new ParameterizedThreadStart(DoWork2)); // если в принимаемом методе есть оргумент (параметр)
            //thread2.Start(int.MaxValue);

            //int j = 0;
            //for (int i = 0; i < int.MaxValue; i++)
            //{
            //    j++;

            //    if (j % 10000 == 0)
            //    {
            //        Console.WriteLine("DoWork");
            //    }
            //}
            #endregion

            //Console.WriteLine("Begin main");

            var result = SaveFileAsync("e:\\test.txt");

            Console.ReadLine();

            Console.WriteLine(result.Result);

            #region Async_Await
            //DoWorkAsync(1000);

            //Console.WriteLine("Continue main");

            //for (int i = 0; i < 10; i++)
            //{
            //        Console.WriteLine("Main");
            //}

            //Console.WriteLine("End main");

        #endregion 
            
            Console.ReadLine();
        }

        static async Task<bool> SaveFileAsync (string path)
        {
            var result = await Task.Run(() => SaveFile(path));
            return result;
        }

        static bool SaveFile(string path)
        {

            var rnd = new Random();
            var text = "";


            for (int i = 0; i < 50000; i++)
            {
                text += rnd.Next();
            }

            using (var sw = new StreamWriter(path, false, System.Text.Encoding.UTF8))
            {
                sw.WriteLine();
            }

            return true;
        }


        static async Task DoWorkAsync(int max)
        {
            Console.WriteLine("Begin Async");
            await Task.Run(() => DoWork(max));
            Console.WriteLine("End Async");
        }

        static void DoWork(int max)
        {

            for (int i = 0; i < max; i++)
            {
                Console.WriteLine("Async");
            }
        }

        static void DoWork2(object max)
        {
            int j = 0;
            for (int i = 0; i < (int)max; i++)
            {
                j++;

                if (j % 10000 == 0)
                {
                    Console.WriteLine("DoWork2");
                }
            }
        }
    }
}
