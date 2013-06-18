using System;

namespace Problem2LeastMajorityMultiple
{
    class Problem2LeastMajorityMultiple
    {
        static void Main()
        {
            //Console.Write("Enter A=");
            int a = int.Parse(Console.ReadLine());
            //Console.Write("Enter B=");    
            int b = int.Parse(Console.ReadLine());
            //Console.Write("Enter C=");    
            int c = int.Parse(Console.ReadLine());
            //Console.Write("Enter D=");    
            int d = int.Parse(Console.ReadLine());
            //Console.Write("Enter E=");    
            int e = int.Parse(Console.ReadLine());

            for (int commonMajority = 1; commonMajority <= 100*100*100; commonMajority++)
            {
                int counter = 0;
                if (commonMajority % a == 0)
                {
                    counter++;
                }
                if (commonMajority % b == 0)
                {
                    counter++;
                }
                if (commonMajority % c == 0)
                {
                    counter++;
                }
                if (commonMajority % d == 0)
                {
                    counter++;
                }
                if (commonMajority % e == 0)
                {
                    counter++;
                }
                if (counter >= 3)
                {
                    Console.WriteLine(commonMajority);
                    break;
                }
            }
            //Console.WriteLine(a+" "+b+" "+c+" "+d+" "+e);
        }
    }
}
