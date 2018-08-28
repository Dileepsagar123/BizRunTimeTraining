using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingApp
{
    class ThreadPoolSample
    {
        public static void Task(object stateInfo)
        {
            Console.WriteLine("Hello from the thread pool");
        }

        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(Task);
            Console.WriteLine("has done some work and going to sleep");
            Thread.Sleep(2000);
            Console.WriteLine("main thread exits here");
            Console.ReadKey();
        }
    }
}
