using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Nhap a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap b = ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c = ");
            c = double.Parse(Console.ReadLine());
            if (a > 0 && b > 0 && c > 0 && (a + b) > c && (a + c) > b && (b + c) > a)
                Console.WriteLine("a, b, c la do dai 3 canh cua mot tam giac");
            else
                Console.WriteLine("a, b, c khong la do dai 3 canh cua mot tam giac");
            Console.ReadLine();
        }
    }
}
