using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingApp
{
    class ThreadpoolTest
    {
        private const int NumThreads = 5;
        private static int[] inputArray;
        private static double[] resultArray;
        private static ManualResetEvent[] resetEvents;
        static void Main(string[] args)
        {
            inputArray = new int[NumThreads];
            resultArray = new double[NumThreads];
            resetEvents = new ManualResetEvent[NumThreads];
        }
    }
}
