using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ThreadingApp
{
    class DiffTaskOnThread
    {
        public static void AddFunc()
        {
            int a = 5;
            int b = 10; 
            Console.WriteLine(a + b);
        }
        public static void SubFunc()
        {
            int a = 100;
            int b = 300;
            Console.WriteLine(a - b);
        }
        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(DiffTaskOnThread.AddFunc));
            Thread thread1 = new Thread(new ThreadStart(DiffTaskOnThread.SubFunc));
            thread.Start();
            thread1.Start();
            Console.ReadKey();
        }
    }
}
