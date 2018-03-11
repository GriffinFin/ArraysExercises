using System;

namespace EqualSums
{
    internal class Program
    {
        static int SumLeft(int[] array, int pos)
        {
            int sum = 0;
            for (int i = pos-1; i >= 0; i--)
            {
                sum += array[i];
            }

            return sum;
        }

        static int SumRight(int[] array, int pos)
        {
            int sum = 0;
            for (int i = pos+1; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }
        public static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            bool noMatch = true;
            for (int i = 0; i < input.Length; i++)
            {
                if (SumLeft(input, i)==SumRight(input, i))
                {
                    Console.WriteLine(i);
                    noMatch = false;
                }
            }

            if (noMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}