using System;

namespace Thread_HomeWork_DZ_1
{
    class Program
    {
        static void Main(string[] args)
        {
            new Runner().StartThread(); // Запуск потоков!
            Console.WriteLine("Main Finish!");
            Console.ReadKey();
        }
    }
}
