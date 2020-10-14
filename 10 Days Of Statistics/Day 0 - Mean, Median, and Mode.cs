using System;

namespace Day_0___Mean__Median__and_Mode
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 0;
            // take input from the user
            size = Convert.ToInt32(Console.ReadLine());
            var inputStringArray = Console.ReadLine().Split(' ');
            var inputIntArray = new int[size];


            /******************      MEAN code start here        ******************/

            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                inputIntArray[i] = int.Parse(inputStringArray[i]);
                sum += inputIntArray[i];
            }
            Console.WriteLine((double)sum / size);


            /******************      MEDIAN code start here        ******************/

            Array.Sort(inputIntArray);
            double median = 0;

            if (size % 2 == 0)
            {
                median = (inputIntArray[size / 2 - 1] + inputIntArray[size / 2]) / 2.0;
            }
            else
            {
                median = inputIntArray[size / 2];
            }
            Console.WriteLine(median);


            /******************      MODE code start here        ******************/

            int maxValue = 0;
            int maxCount = 0;
            for (int i = 0; i < size; i++)
            {
                int count = 0;
                for (int j = 0; j < size; j++)
                {
                    if (inputIntArray[i] == inputIntArray[j])
                    {
                        ++count;
                    }
                    if (count > maxCount)
                    {
                        maxCount = count;
                        maxValue = inputIntArray[i];
                    }
                }
            }
            Console.WriteLine((double)maxValue);
        }
    }
}