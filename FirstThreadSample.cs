using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ThreadingApp
{
    class FirstThreadSample
    {
         
            public static void Main(string[] args)
            {
                Thread t = Thread.CurrentThread;
                t.Name = "MainThread";
                Console.WriteLine(t.Name);
                Console.ReadKey();
            }
         
    }
}
