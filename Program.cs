using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Number range (n1:n2)");
            Console.WriteLine("Enter n1");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter n2");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Prime numbers are:");
            bool prime = true;
            for (int x = n1; x <= n2; x++)
            {
                for (int y = 2; y <= n2; y++)
                {
                    if (x % y == 0 && x != y)
                    {
                        prime = false;
                        break;
                    }

                }
                if (x == 1)
                {
                    prime = false;

                }
                if (prime)
                {
                    Console.Write("\t" + x);
                }
                prime = true;
            }
            Console.ReadKey();
        }
    }
}
