using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ThreadingApp
{
    class AsynchronousSolution
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Begins here");
            method1();
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
       private static async void method1()
        {
            int value = await method2();
            Console.WriteLine("output of method2 : " + value);
        }
        public static Task<int> method2()
        {
            return Task.Run(() => 
            {
                Thread.Sleep(5000);
                return 12;
            }); 
        }

    }
}
