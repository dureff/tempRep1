using System;

namespace Problem1MathExpression
{
    class Program
    {
        static void Main()
        {
            /*Console.Write("N=");
            double n = double.Parse(Console.ReadLine());
            Console.Write("M=");
            double m = double.Parse(Console.ReadLine());
            Console.Write("P=");
            double p = double.Parse(Console.ReadLine());

            double result = (((n * n) + (1 / (m * p)) + 1337) / (n - (128.523123123 * p))) + Math.Sin(m % 180);

            Console.WriteLine("{0:0.000000}",result);*/
            //Console.WriteLine(n+" "+m+" "+p); -2.570352 -3.47200583634357 -3.47200583634357

            Console.Write("N = ");
            decimal n = decimal.Parse(Console.ReadLine());
            Console.Write("M = ");
            decimal m = decimal.Parse(Console.ReadLine());
            Console.Write("P = ");
            decimal p = decimal.Parse(Console.ReadLine());

            decimal chislitel = (n * n) + (1 / (m * p)) + 1337;
            decimal znamenatel = (n - (128.523123123m * p));
            double mod = (int)(m % 180);
            
            mod = Math.Sin(mod);
            
            decimal result = (chislitel / znamenatel) + (decimal)mod;

            Console.WriteLine();
            Console.WriteLine("{0:0.000000}", result);
            Console.WriteLine();
            //-2.570352 -3.596568 - -3.596421
        }
    }
}
