using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Triplets
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int n;
            int r;
            double res;
            double val;

            //Read line, and split it by whitespace into an array of strings
            string[] input = Console.ReadLine().Split();

            //Parse element 0
            n = int.Parse(input[0]);

            //Parse element 1
            r = int.Parse(input[1]);

            Dictionary<double, double> second = new Dictionary<double, double>();
            Dictionary<double, double> third = new Dictionary<double, double>();

            int v = n--;
            while (v)
            {
                val = Console.ReadLine();

                if (third.Count(val))
                    res += third[val];
                if (second.Count(val))
                    third[val * r] += second[val];
                second[val * r]++;
            }

            Console.WriteLine(res);
        }
    }
}
