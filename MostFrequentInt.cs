using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace MostFrequentInt
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            int[] unique = input.Distinct().ToArray();
            int counter = 0;
            int value = 0;
            int mostFrequent = 0;
            for (int i = 0; i < unique.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (unique[i]==input[j])
                    {
                        counter += 1;
                    }
                }

                if (counter>mostFrequent)
                {
                    mostFrequent = counter;
                    value = unique[i];
                }

                counter = 0;
            }

            Console.WriteLine(value);
        }
    }
}