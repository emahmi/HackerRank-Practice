using System;
using System.Linq;

namespace Day_1___Quartiles
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            int[] inputIntArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Array.Sort(inputIntArray);

            int medianLowerHalf = quartile(inputIntArray.Take(size / 2).ToArray());
            int median = quartile(inputIntArray);
            int medianUpperHalf = quartile(inputIntArray.Reverse().Take(size / 2).ToArray());

            Console.WriteLine(medianLowerHalf);
            Console.WriteLine(median);
            Console.WriteLine(medianUpperHalf);

        }

        public static int quartile(int[] array)
        {
            int sizeOfArray = array.Length;
            if (sizeOfArray % 2 == 0)
                return (array[sizeOfArray / 2] + array[sizeOfArray / 2 - 1]) / 2;
            else
                return array[(sizeOfArray - 1) / 2];
        }
    }
}
