using System;

namespace LetterIndex
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            char[] alphabet = new Char[26];
            int counter = 0;
            for (char i = 'a'; i <= 'z'; i++)
            {
                alphabet[counter] = i;
                counter += 1;
            }

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    if (input[i]==alphabet[j])
                    {
                        Console.WriteLine($"{input[i]} -> {j}");
                        break;
                    }
                }
            }
        }
    }
}