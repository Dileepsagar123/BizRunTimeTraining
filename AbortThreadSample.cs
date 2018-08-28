using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingApp
{
    class AbortThreadSample
    {
        public void Thread1()
        {
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Start Main Method");
            AbortThreadSample abortThreadSample = new AbortThreadSample();
            Thread thread = new Thread(new ThreadStart(abortThreadSample.Thread1));
            Thread thread1 = new Thread(new ThreadStart(abortThreadSample.Thread1));
            thread.Start();
            thread1.Start();
            try
            {
                thread.Abort();
                thread1.Abort();
            }
            catch(ThreadAbortException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("End Main Method");
            Console.ReadKey();
        }
    }
}
