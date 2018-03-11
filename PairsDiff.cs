using System;

namespace PairsDiff
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            int number = Int32.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[i]-input[j]==number)
                    {
                        counter += 1;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}