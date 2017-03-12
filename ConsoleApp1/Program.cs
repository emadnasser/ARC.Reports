using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = Stopwatch.StartNew();
            var x = SData.Test_01();
            watch.Stop();
            Console.WriteLine("Test_01 Total Milliseconds: {0} Counts: {1}", watch.Elapsed.Milliseconds, x.Count);

            watch = Stopwatch.StartNew();
            var y = SData.Test_02();
            watch.Stop();
            Console.WriteLine("Test_02 Total Milliseconds: {0} Counts: {1}", watch.Elapsed.Milliseconds, y.Count);
        }
    }
}
