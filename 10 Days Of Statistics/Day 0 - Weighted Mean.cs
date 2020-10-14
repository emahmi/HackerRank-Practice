using System;

namespace Day_0___Weighted_Mean
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double calculatedWeight = 0;

            var size = Convert.ToInt32(Console.ReadLine());

            var valueStringArray = Console.ReadLine().Split(' ');
            var valueIntArray = new double[100];



            for (var i = 0; i < size; i++)
            {
                valueIntArray[i] = double.Parse(valueStringArray[i]);
            }

            var weightStringArray = Console.ReadLine().Split(' ');
            var weightIntArray = new double[100];
            for (var j = 0; j < size; j++)
            {
                weightIntArray[j] = double.Parse(weightStringArray[j]);
            }

            for (var k = 0; k < size; k++)
            {
                calculatedWeight = (double)(calculatedWeight + valueIntArray[k] * weightIntArray[k]);
                sum = (double)(sum + weightIntArray[k]);
            }

            var weightedMean = calculatedWeight / sum;
            Console.WriteLine(weightedMean.ToString("0.0"));

        }
    }
}