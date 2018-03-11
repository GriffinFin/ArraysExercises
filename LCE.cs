using  System;

namespace LargestCommonEnd
{
    internal class Program
    {
        static int LeftEnd(string[] A, string[] B)
        {
            int counter = 0;
            for (int i = 0; i < Math.Min(A.Length, B.Length); i++)
            {
                if (A[i]==B[i])
                {
                    counter += 1;
                }
                else
                {
                    break;
                }
            }

            return counter;
        }

        static int RightEnd(string[] A, string[] B)
        {
            int counter = 0;
            int lenA = A.Length-1;
            int lenB = B.Length-1;
            bool match = true;
            while (match && lenA != -1 && lenB != -1) 
            {
                if (A[lenA]==B[lenB])
                {
                    counter += 1;
                    lenA -= 1;
                    lenB -= 1;
                }
                else
                {
                    match = false;
                }
            }
            return counter;
        }
        public static void Main(string[] args)
        {
            string[] inputA = Console.ReadLine().Split(' ');
            string[] inputB = Console.ReadLine().Split(' ');
            int left = LeftEnd(inputA, inputB);
            int right = RightEnd(inputA, inputB);
            Console.WriteLine(Math.Max(left,right));
        }
    }
}