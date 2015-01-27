using System;
using System.Diagnostics;

namespace CsharpSolutions.Exercises.Task24
{
    static class Example
    {
        public static void Showcase()
        {
            Console.WriteLine("Compute Pi (Sequential)");
            Measure(() => Pi.ComputePi());
            Console.WriteLine("Compute Pi (Parallel)");
            Measure(() => Pi.ComputePiParallel());
        }

        static void Measure(Action action)
        {
            var sw = Stopwatch.StartNew();
            action();
            Console.WriteLine("Time = {0} ms", sw.ElapsedMilliseconds.ToString());
        }
    }
}
