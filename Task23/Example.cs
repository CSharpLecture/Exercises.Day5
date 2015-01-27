using System;
using System.Diagnostics;

namespace CsharpSolutions.Exercises.Task23
{
    static class Example
    {
        public static void Showcase()
        {
            Console.WriteLine("Compute Pi (sync)");
            Measure(() => Pi.ComputePi());
            Console.WriteLine("Compute Pi (async)");
            Measure(() => Pi.ComputePiAsync().Wait());
        }

        static void Measure(Action action)
        {
            var sw = Stopwatch.StartNew();
            action();
            Console.WriteLine("Time = {0} ms", sw.ElapsedMilliseconds.ToString());
        }
    }
}
