using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1___Standard_Deviation
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            int[] inputArray = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
            //sum of squares of distance of each element from mean
            double standardDeviation = 0;
            for (int i = 0; i < inputNumber; i++)
            {
                standardDeviation += Math.Pow((inputArray[i] - inputArray.Average()), 2.0);
            }
            standardDeviation = Math.Sqrt(standardDeviation / inputNumber);
            Console.WriteLine(Math.Round(standardDeviation, 1));
        }
    }
}
