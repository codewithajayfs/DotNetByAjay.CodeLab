using System;
using System.Threading;

namespace ConsoleThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My Current Thread Is - " + Thread.CurrentThread.Name);
            Console.WriteLine("Hello, World!");

            Thread th = Thread.CurrentThread;
            th.Name = "Main 2 Thread";

            Console.WriteLine("Thread name - " + th.Name);
            Console.WriteLine("My Current Thread Is - " + Thread.CurrentThread.Name);
        }
    }
}
