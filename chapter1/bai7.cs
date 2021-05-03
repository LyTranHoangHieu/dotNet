using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            double dcb, dnc;
            do
            {
                Console.WriteLine("Nhap diem co ban = ");
                dcb = double.Parse(Console.ReadLine());
            } while (dcb < 0);
            do
            {
                Console.WriteLine("Nhap diem nang cao = ");
                dnc = double.Parse(Console.ReadLine());
            } while (dnc < 0) ;
            double dtb = (dcb + dnc) / 2;
            if (dtb >= 9 && dcb >= 8 && dnc >= 8)
                Console.WriteLine("Xuat sac");
            else
            {
                if (dtb >= 8 && dcb >= 7 && dnc >= 7)
                    Console.WriteLine("Gioi");
                else
                {
                    if (dtb >= 7 && dcb >= 6 && dnc >= 6)
                        Console.WriteLine("Kha");
                    else
                    {
                        if (dtb >= 5 && dcb >= 3 && dnc >= 3)
                            Console.WriteLine("Trung binh");
                        else
                            Console.WriteLine("Khong dat");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
