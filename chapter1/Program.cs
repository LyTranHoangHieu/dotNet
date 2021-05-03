using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai12
{
    class Program
    {
        static void hinhtron(double r)
        {
            Console.WriteLine("Chu vi = {0}", 2 * Math.PI * r);
            Console.WriteLine("Dien tich = {0}", Math.PI * r * r);
        }
        static void hinhchunhat(double a, double b)
        {
            Console.WriteLine("Chu vi = {0}", (a + b) * 2);
            Console.WriteLine("Dien tich = {0}", a * b);
        }
        static void hinhthang(double a, double b, double c, double d, double h)
        {
            Console.WriteLine("Chu vi = {0}", a + b + c + d);
            Console.WriteLine("Dien tich = {0}", (a + b) * h / 2);
        }
        static void tamgiac(double a, double b, double c)
        {
            Console.WriteLine("Chu vi = {0}", a + b + c);
            double p = (a + b + c) / 2;
            Console.WriteLine("Dien tich = {0}", Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hinh tron");
            hinhtron(2);
            Console.WriteLine("Hinh chu nhat");
            hinhchunhat(4, 3);
            Console.WriteLine("Hinh thang");
            hinhthang(5, 10, 7, 9, 6);
            Console.WriteLine("Tam giac");
            tamgiac(3, 4, 5);
            Console.ReadLine();
        }
    }
}
