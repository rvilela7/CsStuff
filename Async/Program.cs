﻿using System;
using System.Threading.Tasks;
using System.IO;

namespace task_demo
{
  class Program
  {
      static async Task<string> ReadTxtFile() 
      {
          using(var sr = new StreamReader(File.Open("test.txt", FileMode.Open)))
          {
              return await sr.ReadToEndAsync();
          }
      }

      static string ReadFileSync1() 
      {
          Task.Delay(2000).Wait();
          return "content1";
      }

      static string ReadFileSync2()
      {
          Task.Delay(2000).Wait();
          return "content2";
      }

      static string ReadFileSync3()
          {
          Task.Delay(2000).Wait();
          return "content3";
      }
      
      static async Task DoSomething()
      {
          await Task.Delay(2000);
      }
      static async Task<int> Sum(int a, int b) 
      {
          var result = await Task.FromResult(a + b);
          return result;
      }

      static async Task<string> ReadFile1() 
      {
          await Task.Delay(3000);
          return "file1";
      }

      static async Task<string> ReadFile2()
      {
          await Task.Delay(4000);
          return "file2";
      }

      static async Task<string> ReadFile3()
      {
          await Task.Delay(2000);
          return "file3";
      }

      static void Main(string[] args)
      {
          var start = DateTime.Now;
          var c1 = ReadFileSync1();
          var c2 = ReadFileSync2();
          var c3 = ReadFileSync3();
          var end = DateTime.Now;
          Console.WriteLine("Time taken {0}", end-start);

          start  = DateTime.Now;

          var taskSum = Sum(2,2);
          var taskDelay = DoSomething();

          Task.WaitAll(taskSum, taskDelay);

          end = DateTime.Now;

          Console.WriteLine("{0}",taskSum.Result);

          Console.WriteLine("Time taken! {0}", end-start);

          var task1 = ReadFile1();
          var task2 = ReadFile2();
          var task3 = ReadFile3();

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