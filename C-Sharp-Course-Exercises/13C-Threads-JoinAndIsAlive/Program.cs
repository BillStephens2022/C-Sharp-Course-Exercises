using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._13C_Threads_JoinAndIsAlive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread started");
            Thread thread1 = new Thread(Thread1Function);
            Thread thread2 = new Thread(Thread2Function);
            thread1.Start();
            thread2.Start();

            if (thread1.Join(1000))
            {
                Console.WriteLine("Thread1Function done!");
            }
            else
            {
                Console.WriteLine("Thread1Function wasn't done within 1 second.");
            }

            thread2.Join();
            Console.WriteLine("Thread2Function done");

            for (int i = 0; i < 10; i++)
            {
                if (thread1.IsAlive)
                {
                    Console.WriteLine("Thread 1 is still alive and doing stuff");
                    Thread.Sleep(300);
                }
                else
                {
                    Console.WriteLine("Thread 1 is ended");
                }
            }

            Console.WriteLine("Main Thread ended");
        }

        public static void Thread1Function()
        {
            Console.WriteLine("Thread1Function started");
            Thread.Sleep(3000);
            Console.WriteLine("Thread1Function coming back to caller");
        }

        public static void Thread2Function()
        {
            Console.WriteLine("Thread2Function started");
        }
    }
}
