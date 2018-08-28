using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ThreadingApp
{
    class InstanceThreadMethodSample
    {
        public void InstanceMethod()
        {
            for(int i =0; i <= 20; i++)
            {
                Console.WriteLine(Thread.CurrentThread);
                Thread.Sleep(3000);
            }
        }
        static void Main(string[] args)
        {
            InstanceThreadMethodSample instanceThreadMethodSample = new InstanceThreadMethodSample();
            Thread t1 = new Thread(new ThreadStart(instanceThreadMethodSample.InstanceMethod));
            Thread t2 = new Thread(new ThreadStart(instanceThreadMethodSample.InstanceMethod));
            t1.Start();
            t2.Start();
            Console.ReadKey();
        }
    }
}
