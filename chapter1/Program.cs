using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai17
{
    class Program
    {
        static long factorial(int n)
        {
            long factorial = 1;
            for (int i = 1; i <= n; i++)
                factorial *= i;
            return factorial;
        }
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("Nhap n = ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);
            double x;
            Console.WriteLine("Nhap x = ");
            x = double.Parse(Console.ReadLine());
            double e = 1;
            for (int i = 1; i <= n; i++)
                e += Math.Pow(-1, i + 1) * Math.Pow(x, i) / factorial(i);
            Console.WriteLine(e);
            Console.ReadLine();
        }
    }
}
