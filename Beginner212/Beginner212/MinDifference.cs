using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Beginner212
{
    class MinDifference
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            
            var a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var b = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Array.Sort(a);
            Array.Sort(b);

            int result = 0;
            int ans;

            for(int i=0;i<n;i++)
            {
                for (int j = 0; j < m; j++)
                {
                    ans = Math.Abs(a[i] - b[i]);
                    if(ans > result)
                    {
                        break;
                    }
                    if(ans == 0)
                    {
                        Console.WriteLine(0);
                        return;
                    }
                    result = ans;
                }
            }
            Console.WriteLine(result);
        }
    }
}
