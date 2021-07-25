using System;

namespace Beginner211
{
    class BloodPressure
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);

            double c = (double)(a - b) / 3 + b;

            Console.WriteLine(c);
        }
    }
}
