using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double s = 0;
            Console.WriteLine("Nhap n = ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
                s += (double)i / (i + 1);
            Console.WriteLine("Tong s = {0}", s);
            Console.ReadLine();
        }
    }
}
