using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadingApp
{
    class Asynchronus
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Begins Here");
            method1();
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("value of i " + i);

            }
            Console.ReadKey();
        }
        static void method1()
        {
            int n = Method2();
            Console.WriteLine("method2 " + n);
        }
        static int Method2()
        {
            System.Threading.Thread.Sleep(5000);
            return 1;
        }
    }
}
