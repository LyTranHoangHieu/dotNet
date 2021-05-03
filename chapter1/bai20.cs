using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai20
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("Nhap n = ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);
            int uoc = 0;
            for (int i = 1; i <= n / 2; i++)
                if (n % i == 0 && i % 2 != 0)
                    uoc = i;
            Console.WriteLine(uoc);
            Console.ReadLine();
        }
    }
}
