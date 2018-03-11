using System;

namespace FoldAndSum
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            int k = input.Length / 4;
            int[] bottom = new int[2*k];
            int[] top = new int[k];
            int[] top2 = new int[k];
            Array.Copy(input,0,top,0,k);
            Array.Copy(input,3*k,top2,0,k);
            Array.Reverse(top);
            Array.Reverse(top2);           
            Array.Copy(input, k, bottom, 0, 2 * k);
            for (int i = 0; i < k; i++)
            {
                int current = bottom[i] + top[i];
                Console.Write(current + " ");
            }
            for (int i = 0; i < k; i++)
            {
                int current = bottom[k +i] + top2[i];
                Console.Write(current + " ");
            }
        }
    }
}