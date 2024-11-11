using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LINQFluent
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> lines = File.ReadAllLines("Teste.txt");

            int qtyLargarThan30 = lines.Count(s => s.Length > 30);
            Console.WriteLine(qtyLargarThan30);

            double avgLineLen = lines.Average(s => s.Length);
            Console.WriteLine(avgLineLen);

            bool isLineHigherThan120 = lines.Any(s => s.Length > 120);
            Console.WriteLine(isLineHigherThan120);

            IEnumerable<string> firstWY = lines.Where(s => s.Contains("Y")).Select(s => s.Split()[0]);
            Console.WriteLine(firstWY);

            foreach(string word in firstWY)
            {
                Console.WriteLine(firstWY);
            }


        }
    }
}
