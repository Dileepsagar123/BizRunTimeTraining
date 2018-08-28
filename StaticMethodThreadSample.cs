using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ThreadingApp
{
    class StaticMethodThreadSample
    {
        public static void Staticmethod()
        {
            for(int i = 0; i <= 50; i++ )
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(StaticMethodThreadSample.Staticmethod));
            Thread t2 = new Thread(new ThreadStart(StaticMethodThreadSample.Staticmethod));
            t1.Start();
            t2.Start();
            Console.ReadKey();
        }
    }
}
