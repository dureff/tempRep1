using System;

namespace HW04DevideFactorial
{
    class Program
    {
        static void Main()
        {
            //Console.Write("K=");
            //string numberK = Console.ReadLine();
            //Console.Write("N=");
            //string numberN = Console.ReadLine();
            //int k = Convert.ToInt32(numberK);
            //int n = Convert.ToInt32(numberN);
            //int factorialK = 1;
            //int factorialN = 1;

            //do
            //{
            //    factorialK *= k;
            //    factorialN *= n;
            //    k--;
            //    n--;
            //}
            //while (k > 0 & n > 0 );
            //Console.WriteLine("K! = " + factorialK);
            //Console.WriteLine("N! = " + factorialN);
            //Console.WriteLine(factorialN % factorialK);

            Console.Write("K=");
            string numberK = Console.ReadLine();
            int k = Convert.ToInt32(numberK);
            int factorialK = 1;

            do
            {
                factorialK *= k;
                k--;
            }
            while (k > 0);
            Console.WriteLine("K! = " + factorialK);

            Console.Write("N=");
            string numberN = Console.ReadLine();
            int n = Convert.ToInt32(numberN);
            int factorialN = 1;

            do
            {
                factorialN *= n;
                n--;
            }
            while (n > 0);
            Console.WriteLine("N! = " + factorialN);
            Console.WriteLine(factorialN % factorialK);
        }
    }
}
