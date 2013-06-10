using System;

namespace HW02From1ToNAndNotDevideBy3And7
{
    class HW02From1ToNAndNotDevideBy3And7
    {
        static void Main()
        {
            Console.Write("N=");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                //Console.WriteLine(i);
                if (i % 3 == 0)
                {
                    Console.WriteLine();
                }
                else if (i % 7 == 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(i);
                }
                //if (i == n)
                //{
                //    break;
                //}
                //Console.Write(", ");
            }
            
        }
    }
}
