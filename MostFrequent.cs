using System;
using System.Linq;
namespace _08
{
    class Program
    {
        static void Main(string[] args)
        {
            uint[] ArrOfNums = Console.ReadLine().Split(' ').Select(s => uint.Parse(s)).ToArray();
            uint counter = 1;
            uint countmax = 0;
            uint nummax = 0;
            for (int i =ArrOfNums.Length-1  ; i >=0 ; i--)
            {
                for (int e =ArrOfNums.Length-1 ; e >=0 ; e--)
                {
                    if (ArrOfNums[i]==ArrOfNums[e])
                    {
                        counter += 1;
                        if (counter>=countmax)
                        {
                            nummax = ArrOfNums[i];
                            countmax = counter;
                        }
                    }
                }

                counter = 1;
            }
            Console.WriteLine(nummax);
        }
    }
}