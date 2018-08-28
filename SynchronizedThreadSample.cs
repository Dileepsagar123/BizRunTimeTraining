using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingApp
{
    class SynchronizedThreadSample
    {
        public void Task()
        {
            lock(this)
            {
                for(int i = 0; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Main(string[] args)
        {
            SynchronizedThreadSample synchronizedThreadSample = new SynchronizedThreadSample();
            Thread t1 = new Thread(new ThreadStart(synchronizedThreadSample.Task));
            Thread t2 = new Thread(new ThreadStart(synchronizedThreadSample.Task));
            t1.Start();
            t2.Start();
            Console.ReadKey();
        }
    }
}
