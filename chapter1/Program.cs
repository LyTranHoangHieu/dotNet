using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai22
{
    class Program
    {
        static int Fibonacci(int n)
        {
            if (n == 0 || n == 1)
                if (n == 0)
                    return 0;
                else
                    return 1;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("Nhap n = ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);
            for (int i = 0; i < n; i++)
                Console.Write(Fibonacci(i) + " ");
            Console.ReadLine();
        }
    }
}
