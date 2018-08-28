using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingApp
{
    class PriorityThreadSample
    {
        public static void Task()
        {
            Thread t1 = Thread.CurrentThread;
            Console.WriteLine(t1.Name + " is running....");
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(ThreadNameSample.Task));
            Thread t2 = new Thread(new ThreadStart(ThreadNameSample.Task));
            Thread t3 = new Thread(new ThreadStart(ThreadNameSample.Task));

            t1.Name = "player1";
            t2.Name = "player2";
            t3.Name = "player3";
           
            t2.Priority = ThreadPriority.Highest;
            t3.Priority = ThreadPriority.Normal;
            t1.Priority = ThreadPriority.Lowest;

            t1.Start();
            t2.Start();
            t3.Start();
            Console.ReadKey();
        }
    }
}
