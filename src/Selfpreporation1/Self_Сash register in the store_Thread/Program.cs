using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;

namespace Self_Сash_register_in_the_store_Thread
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Магазин открыт");

            var clients = new List<Guid>();

            for (int i = 0; i < 15; i++)
            {
                new Shop(Guid.NewGuid());
              
            }

            Console.ReadLine();
        }
    }
    class Shop
    {
        private static SemaphoreSlim semaphore = new SemaphoreSlim(3);
        private readonly Thread thread;

        public Shop(Guid guid)
        {
            thread = new Thread(Buy)
            {
                Name = guid.ToString()
            };
            thread.Start();
        }

        public void Buy ()
        {
            //Console.WriteLine($"Касса номер: {Thread.CurrentThread.Name}");

            semaphore.Wait();

            if (DateTime.Now.Minute < 57)
            {
                

                var random = new Random();
                var time = random.Next(1000, 20000);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Касса {Thread.CurrentThread.Name} бслуживается, время на обслуживание: {time / 1000} сек");
                Console.ForegroundColor = ConsoleColor.White;
                
                Thread.Sleep(time);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Касса {Thread.CurrentThread.Name} свободна");
                Console.ForegroundColor = ConsoleColor.White;   
            }
            else
            {
                Console.WriteLine("Магазин закрыт");
                
            }

            semaphore.Release();

        }
    }
}
