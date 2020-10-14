using System;

namespace Day_4___Binomial_Distribution_I
{
    class Program
    {
        static double factorial(double num)
        {
            if (num == 0)
            {
                return 1;
            }
            return (num * factorial((num - 1)));

        }
        static void Main(String[] args)
        {
            double probability = 0.0, sum = 0.0;

            var input = Console.ReadLine().Split();
            var boys = double.Parse(input[0]);
            var girls = double.Parse(input[1]);

            var total = boys + girls;
            var p = boys / total;       //numerator
            var q = 1.0 - p;            //denominator
            var x = 3.0;                     // at least boys = 3
            var n = 6.0;                     //total children = 6

            for (var i = x; i <= n; i++)
            {
                probability = (factorial(n) * Math.Pow(p, i) * Math.Pow(q, n - i)) / (factorial(i) * factorial(n - i));
                sum += probability;
            }
            Console.WriteLine(sum.ToString("0.000"));
        }
    }
}