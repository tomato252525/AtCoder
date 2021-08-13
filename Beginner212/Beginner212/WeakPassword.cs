using System;
using System.Collections.Generic;
using System.Text;

namespace Beginner212
{
    class WeakPassword
    {
        static void Main(string[] args)
        {
            char[] x = Console.ReadLine().ToCharArray();
            int weakFlg1 = 0, weakFlg2 = 0;

            for (int i = 1; i < x.Length; i++)
            {
                int a = (int)Char.GetNumericValue(x[i - 1]);
                int b = (int)Char.GetNumericValue(x[i]);
                if (a == 9)
                {
                    a = -1;
                }
                if (x[i - 1] == x[i])
                {
                    weakFlg1++;
                }
                else if ((a + 1) == b)
                {
                    weakFlg2++;
                }
                else
                {
                    Console.WriteLine("Strong");
                    return;
                }
                if (weakFlg1 != 0 && weakFlg2 != 0)
                {
                    Console.WriteLine("Strong");
                    return;
                }
            }
            Console.WriteLine("Weak");
        }
    }
}
