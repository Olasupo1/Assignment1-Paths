using System;
using System.Collections.Generic;
using System.Linq;

namespace Paths
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<string>> paths = new List<List<string>>
            {
                new List<string> {"London", "New York"},
                new List<string> {"New York", "Tampa"},
                new List<string> {"Delhi", "London"}
            };

            System.Console.WriteLine(DestCity(paths));
        }

        private static string DestCity(List<List<string>> paths)
        {

            List<string> list = new List<string>();

            foreach (var path in paths)
            {
                list.Add(path[1]);
            }

            foreach (var path in paths)
            {
                if (list.Contains(path[0]))
                {
                    list.Remove(path[0]);
                }

            }

            return list.Last();
        }
    }
}
