using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai10___bai11
{
    class Program
    {
        static void ptb1(double a, double b)
        {
            if (a == 0)
                if (b == 0)
                    Console.WriteLine("Phuong trinh co vo so nghiem");
                else
                    Console.WriteLine("Phuong trinh vo nghiem");
            else
                Console.WriteLine("Phuong trinh co nghiem x = {0}", -b / a);
        }
        static void ptb2(double a, double b, double c)
        {
            double delta;
            delta = b * b - 4 * a * c;
            if (delta >= 0)
                if (delta == 0)
                    Console.WriteLine("Phuong trinh co nghiem kep x1 = x2 = {0}", -b / 2 * a);
                else
                {
                    double sqrt_delta = Math.Sqrt(delta);
                    Console.WriteLine("Phuong trinh co hai nghiem phan biet");
                    Console.WriteLine("x1 = {0}", (-b + sqrt_delta) / 2 * a);
                    Console.WriteLine("x1 = {0}", (-b - sqrt_delta) / 2 * a);
                }
            else
                Console.WriteLine("Phuong trinh da cho vo nghiem");
        }
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("GIAI PHUONG TRINH BAC HAI AX^2 + BX + C = 0");
            Console.WriteLine("Nhap a = ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b = ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c = ");
            c = double.Parse(Console.ReadLine());
            if (a != 0)
                ptb2(a, b, c);
            else
                ptb1(b, c);
            Console.ReadLine();
        }
    }
}
