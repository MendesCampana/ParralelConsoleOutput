using System;
using System.Threading;
using ParralelConsoleOutput;

namespace ParralelConsoleOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            //I dont see any point in creating separate variables for inputs here, so we create our objects with direct input to the ctors.
            IParallelOutput parralelWriter1 = new ParallelConsoleOutputer("Thread1", 0.1, ConsoleColor.Cyan);
            IParallelOutput parralelWriter2 = new ParallelConsoleOutputer("Thread2", 0.2, ConsoleColor.Gray);

            parralelWriter1.StartOutput();
            parralelWriter2.StartOutput();

            Console.ReadKey();
            parralelWriter1.StopOutput();
            parralelWriter2.StopOutput();
            Thread.Sleep(1000);
               
        }
    }
}
