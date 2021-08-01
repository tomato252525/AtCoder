using System;

namespace Beginner212
{
    class Alloy
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);

            string result;

            if (0 < a && 0 < b)
            {
                result = "Alloy";
            }
            else
            {
                result = a < b ? "Silver" : "Gold";
            }
            Console.WriteLine(result);
        }
    }
}
