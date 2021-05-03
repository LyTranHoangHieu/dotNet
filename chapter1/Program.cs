using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai8
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine(" Nhap vao 2 so bat ky: ");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            char kt;
            Console.WriteLine("Nhap vao 1 ky tu (+, -, *, /): ");
            kt = char.Parse(Console.ReadLine());
            switch (kt)
            {
                case '+':
                    Console.WriteLine("Tong {0} + {1} = {2}", a, b, a + b);
                    break;
                case '-':
                    Console.WriteLine("Hieu {0} - {1} = {2}", a, b, a - b);
                    break;
                case '*':
                    Console.WriteLine("Tich {0} * {1} = {2}", a, b, a * b);
                    break;
                case '/':
                    if (b != 0)
                        Console.WriteLine("Thuong {0} / {1} = {2}", a, b, a / b);
                    else
                        Console.WriteLine("Khong chia duoc vi b = 0");
                    break;
            }
            Console.ReadLine();
        }
    }
}
