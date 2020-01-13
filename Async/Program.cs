using System;
using System.Threading.Tasks;
using Async;

namespace task_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            AsyncTask _asyncTask = new AsyncTask();

            var start = DateTime.Now;
            var c1 = _asyncTask.ReadFileSync1();
            var c2 = _asyncTask.ReadFileSync2();
            var c3 = _asyncTask.ReadFileSync3();
            var end = DateTime.Now;
            Console.WriteLine("Time taken {0}", end - start);

            start = DateTime.Now;

            var taskSum = _asyncTask.Sum(2, 2);
            var taskDelay = _asyncTask.DoSomething();

            Task.WaitAll(taskSum, taskDelay);

            end = DateTime.Now;

            Console.WriteLine("{0}", taskSum.Result);

            Console.WriteLine("Time taken! {0}", end - start);

            var task1 = _asyncTask.ReadFile1();
            var task2 = _asyncTask.ReadFile2();
            var task3 = _asyncTask.ReadFile3();

            start = DateTime.Now;
            Task.WaitAny(task1, task2, task3);


            Console.WriteLine("Task1, completed: {0}", task1.IsCompleted);

            // this forces everyone to wait for this Task1
            // Console.WriteLine("Task1, completed: {0}", task1.Result);

            Console.WriteLine("Task2, completed: {0}", task2.IsCompleted);

            Console.WriteLine("Task3, completed: {0}", task3.IsCompleted);
            Console.WriteLine("Task3, completed: {0}", task3.Result);

            end = DateTime.Now;
            Console.WriteLine("Time taken! {0}", end - start);

        }
    }
}