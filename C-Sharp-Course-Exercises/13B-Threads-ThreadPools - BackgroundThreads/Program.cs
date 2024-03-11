using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._13_Threads_ThreadPools___BackgroundThreads
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            Enumerable.Range(0, 100).ToList().ForEach(f => 
            {
                ThreadPool.QueueUserWorkItem((o) =>
                {
                    Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} started");
                    Thread.Sleep(5000);
                    Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} ended");
                });
              
            });

           Console.ReadLine();
      


        }
    }
}
