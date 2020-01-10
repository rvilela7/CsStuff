using System;
using Async.Classes;

namespace Async
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            Console.ReadKey();

            MyTask tt = new MyTask();
            var c = tt.MyTest1();
        
            Console.WriteLine("End");

        }
    }
}
