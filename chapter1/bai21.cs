using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai21
{
    class Program
    {
        static bool isSoNguyenTo(int n)
        {
            for (int i = 2; i <= n; i++)
                if (n % i == 0 && n != i)
                    return false;
            return true;
        }
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("Nhap n = ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 1);
            for (int i = 2; i < n; i++)
                if (isSoNguyenTo(i))
                    Console.Write(i + " ");
            Console.ReadLine();
        }
    }
}
