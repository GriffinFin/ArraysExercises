using  System;

namespace RotateAndSum
{
    internal class Program
    {
        static int[] RotateRight(int[] rotateThis, int len)
        {
            int[] rotated = new int[rotateThis.Length];
            for (int i = 0; i < len; i++)
            {
                rotated[(i + 1) % len] = rotateThis[i];
            }

            return rotated;
        }

        public static void Main(string[] args)
        {
            int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            int len = array.Length;
            int k = int.Parse(Console.ReadLine());
            int[] sum = new int[len];
            for (int i = 0; i < k; i++)
            {
                int[] rotated = RotateRight(array, len);
                for (int j = 0; j < len; j++)
                {
                    sum[j] += rotated[j];
                }

                array = rotated;
            }

            Console.WriteLine(String.Join(" ", sum));
        }

    }
}