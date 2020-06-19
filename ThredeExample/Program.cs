using System;
using System.Threading;

namespace ThredeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // получаем текущий поток
            Thread t = Thread.CurrentThread;

            //получаем имя потока
            Console.WriteLine($"Имя потока: {t.Name}");
            t.Name = "Метод Main";
            Console.WriteLine($"Имя потока: {t.Name}");

            Console.WriteLine($"Запущен ли поток: {t.IsAlive}");
            Console.WriteLine($"Приоритет потока: {t.Priority}");
            Console.WriteLine($"Статус потока: {t.ThreadState}");

            // получаем домен приложения
            Console.WriteLine($"Домен приложения: {Thread.GetDomain().FriendlyName}");


            Thread myThread = new Thread(new ThreadStart(Count));
            myThread.Start(); // запускаем поток

            Thread errordakan = new Thread(new ThreadStart(Sum));
            errordakan.Start();
            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine("Glxavor:");
                Console.WriteLine(i * i);
                Thread.Sleep(300);
            }


            Console.ReadLine();
        }

        public static void Count()
        {
            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine("erkrordakan:");
                Console.WriteLine(i * i);
                Thread.Sleep(400);
            }
        }

        public static void Sum()
        {
            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine("errordakan:");
                Console.WriteLine(i +i);
                Thread.Sleep(400);
            }
        }
    }
}
