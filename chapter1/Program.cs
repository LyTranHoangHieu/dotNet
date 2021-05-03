using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 6;
            Console.WriteLine("=====CAU A=====");
            for(int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("* ");
                Console.WriteLine();
            }
            Console.WriteLine("=====CAU B =====");
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                    Console.Write("$ ");
                Console.WriteLine();
            }
            Console.WriteLine("=====CAU C=====");
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                    Console.Write("  ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("* ");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
