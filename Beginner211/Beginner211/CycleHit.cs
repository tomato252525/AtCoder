using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Beginner211
{
    class CycleHit
    {
        static void Main(string[] args)
        {
            string[] s = new string[4];
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = Console.ReadLine();
            }
            Console.WriteLine(s.Distinct().Count() == 4 ? "Yes" : "No");
        }
    }
}
