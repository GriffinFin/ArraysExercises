using System;
using System.Linq;

namespace SieveOfEratosthenes
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int[] array = new int[n-1];
            int p = 2;
            int p2 = 0;
            bool morePrimesInRange = true;
            bool secondP = true;
            for (int i = 0; i < n-1; i++)
            {
                array[i] = i + 2;
            }

            while (morePrimesInRange)
            {
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i]%p==0 && array[i]>p)
                    {
                        array[i] = 0;
                    }
                    else if (secondP&&p<array[i])
                    {
                        p2 = array[i];
                        secondP = false;
                    }
                }

                if (p2==p)
                {
                    morePrimesInRange = false;
                    break;
                }
                p = p2;
                secondP = true;
            }

            int[] primes = array.Distinct().ToArray();
            foreach (int prime in primes)
            {
                if (prime!=0)
                {
                    Console.Write(prime + " ");
                }
            }
        }
    }
}