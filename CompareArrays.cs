using System;

namespace CompareArrays
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            char[] arrA = Array.ConvertAll(Console.ReadLine().Split(' '), char.Parse);
            char[] arrB = Array.ConvertAll(Console.ReadLine().Split(' '), char.Parse);
            
            int len = Math.Min(arrA.Length, arrB.Length);
            
            bool areEqual = true;
            
            for (int i = 0; i < len; i++)
            {
                if (arrA[i]<arrB[i])
                {
                    Console.WriteLine(string.Join("", arrA));
                    Console.WriteLine(string.Join("", arrB));
                    areEqual = false;
                    break;
                }
                else if (arrB[i]<arrA[i])
                {
                    Console.WriteLine(string.Join("", arrB));
                    Console.WriteLine(string.Join("", arrA));
                    areEqual = false;
                    break;
                }
            }

            if (areEqual)
            {
                if (arrA.Length<=arrB.Length)
                {
                    Console.WriteLine(string.Join("", arrA));
                    Console.WriteLine(string.Join("", arrB));
                }
                else
                {
                    Console.WriteLine(string.Join("", arrB));
                    Console.WriteLine(string.Join("", arrA));
                }
            }
        }
    }
}