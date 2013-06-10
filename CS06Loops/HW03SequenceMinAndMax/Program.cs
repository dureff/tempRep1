using System;

namespace HW03SequenceMinAndMax
{
    class Program
    {
        static void Main()
        {
            //Console.Write("N of sequence = ");
            //int n = int.Parse(Console.ReadLine());
         
            //int min = int.MaxValue;
            //int max = int.MinValue;

            //for (int i = 0; i < n; i++)
            //{
            //    int current = int.Parse(Console.ReadLine());
            //    if (current < min)
            //    {
            //        min = current;
            //    }
            //    if (current > max)
            //    {
            //        max = current;
            //    }
            //}
            //Console.WriteLine(min);
            //Console.WriteLine(max);

            //Console.Write("N of sequence = ");
            //int n = int.Parse(Console.ReadLine());

            //int min = int.Parse(Console.ReadLine());
            //int max = min;

            Console.Write("N of sequence = ");
            int n = int.Parse(Console.ReadLine());
            int firstValueOfInput = int.Parse(Console.ReadLine());
            int min = firstValueOfInput;
            int max = firstValueOfInput;

            for (int i = 0; i < n -1; i++)
            {
                int current = int.Parse(Console.ReadLine());
                if (current < min)
                {
                    min = current;
                }
                if (current > max)
                {
                    max = current;
                }
            }
            Console.WriteLine(min);
            Console.WriteLine(max);

           // for (int i = 1; i <= n; i++)
           // {
           //     Console.WriteLine();
           //     Console.WriteLine(i);
           // }

           //// int min = 2;

           // // i = 1;
           // //while (i <= n)
           // //{
           // //    Console.WriteLine();
           // //    Console.WriteLine(i);
           // //    i++;
           // //}

            //int[] array =  new int[n];
        }
    }
}
