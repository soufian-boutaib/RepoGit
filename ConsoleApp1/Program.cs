using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


           Console.WriteLine(IntDigit({ 1,7,-2,2,5}));

               
        }

        private static bool IntDigit(int[] v)
        {

            //If there are no temperatures provided, output 0.
            if (N <= 0)
            {
                Console.WriteLine(0);
                return;
            }

            int closestToZero = int.MaxValue;

            for (int i = 0; i < N; i++)
            {
                int T = int.Parse(inputs[i]);

                //Find the closest to zero.
                if (Math.Abs(T) < Math.Abs(closestToZero))
                {
                    closestToZero = T;
                }
                //Find the positive number that is closest to zero instead of the negative number (see 5 and -5).
                else if (Math.Abs(T) == Math.Abs(closestToZero))
                {
                    closestToZero = Math.Max(closestToZero, T);
                }
            }
        }
    }
}
