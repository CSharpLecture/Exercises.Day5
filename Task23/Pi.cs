using System.Threading.Tasks;

namespace CsharpSolutions.Exercises.Task23
{
    static class Pi
    {
        //This is the number of the iterations
        const int N = 1000000000;

        //Computes PI in ordinary manner
        public static double ComputePi()
        {
            //the sum
            var sum = 0.0;
            //the step size which is the inverse of N
            var step = 1.0 / N;

            //this is our integration algorithm
            for (var i = 0; i < N; i++)
            {
                var x = (i + 0.5) * step;
                sum = sum + 4.0 / (1.0 + x * x);
            }

            //Lets return the result and don't forget to normalize
            return sum * step;
        }

        //Here we just wrap everything in a RUNNING task
        public static Task<double> ComputePiAsync()
        {
            return Task.Factory.StartNew(() => ComputePi());
        }
    }
}
