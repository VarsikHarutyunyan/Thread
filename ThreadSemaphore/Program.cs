﻿using System;
using System.Threading;

namespace ThreadSemaphore
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 6; i++)
            {
                Reader reader = new Reader(i);
            }

            Console.ReadLine();
        }
    }

    class Reader
    {
        // создаем семафор
        static Semaphore sem = new Semaphore(3, 3);
        Thread myThread;
        int count = 3;// счетчик чтения

        public Reader(int i)
        {
            myThread = new Thread(Read);
            myThread.Name = $"Reader {i.ToString()}";
            myThread.Start();
        }

        public void Read()
        {
            while (count > 0)
            {
                sem.WaitOne();

                Console.WriteLine($"{Thread.CurrentThread.Name} included in the library");

                Console.WriteLine($"{Thread.CurrentThread.Name} is reading");
                Thread.Sleep(1000);

                Console.WriteLine($"{Thread.CurrentThread.Name} leaves the library");

                sem.Release();

                count--;
                Thread.Sleep(1000);
            }
        }
    }
}
