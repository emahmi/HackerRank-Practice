using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1____Interquartile_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] inputFrequency = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            List<int> list = new List<int>();

            for (int x = 0; x < inputArray.Length; x++)
            {
                for (int y = 0; y < inputFrequency[x]; y++)
                {
                    list.Add(inputArray[x]);
                }
            }
            inputArray = list.OrderBy(x => x).ToArray();

            size = inputArray.Length;
            double LowerHalf = quartile(inputArray.Take(size / 2).ToArray());
            double UpperHalf = quartile(inputArray.Reverse().Take(size / 2).ToArray());
            double Interquartile = UpperHalf - LowerHalf;
          
            Console.WriteLine(Interquartile.ToString("0.0"));
        }
        public static double quartile(int[] inputArray)
        {
            int size = inputArray.Length;
            if (size % 2 == 0)
                return (inputArray[size / 2] + inputArray[size / 2 - 1]) / 2;
            
            else
                return inputArray[(size - 1) / 2];
        }
    }
}