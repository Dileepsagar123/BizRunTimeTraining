using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadingApp
{
    class Program
    {
        static void TestFunc()
        {
            int i; 
            for(i = 0; i <= 50; i++)
            {
                Console.WriteLine("X");
            }
        }
        static void Main(string[] args)
        {
            int i;
            Thread t1 = new Thread(TestFunc);
            t1.Start();
            while (!t1.IsAlive);
            for( i =0;  i <= 50; i ++ )
            {
                Console.WriteLine("Y");
            }
            while (true) ;
        }
    }
}
