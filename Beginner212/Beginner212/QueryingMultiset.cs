using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class QueryingMultiset
    {
        static void Main(string[] args)
        {
            int q = int.Parse(Console.ReadLine());
            var list = new List<int>();
            for (int i = 0; i < q; i++)
            {
                int[] query = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                switch (query[0])
                {
                    case 1:
                        list.Add(query[1]);
                        break;
                    case 2:
                        list = list.Select(x => x + query[1]).ToList();
                        break;
                    case 3:
                        list.Sort();
                        Console.WriteLine(list.First());
                        list.RemoveAt(0);
                        break;

                }
            }
        }
    }
}
