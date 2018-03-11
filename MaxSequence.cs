using System;

namespace MaxSequence
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            int counter = 1;
            int maxCounter = 0;
            int value = 0;
            int previous = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i]==previous)
                {
                    counter += 1;
                    if (counter>maxCounter)
                    {
                        maxCounter = counter;
                        value = input[i];
                    }
                }
                else
                {
                    counter = 1;
                }

                previous = input[i];
            }

            for (int i = 0; i < maxCounter; i++)
            {
                Console.Write(value + " ");
            }
        }
    }
}