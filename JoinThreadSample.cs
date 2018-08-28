using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ThreadingApp
{
    class JoinThreadSample
    {
        public void Task1()
        {
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
        }
        static void Main(string[] args)
        {
            JoinThreadSample joinThreadSample = new JoinThreadSample();
            Thread t1 = new Thread(new ThreadStart(joinThreadSample.Task1));
            Thread t2 = new Thread(new ThreadStart(joinThreadSample.Task1));
            Thread t3 = new Thread(new ThreadStart(joinThreadSample.Task1));
            t1.Start();
            t1.Join();
            t2.Start();
            t3.Start();
            Console.ReadKey();
        }
    }
}
