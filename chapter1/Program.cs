using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai24
{
    class Program
    {
        static void input(int[] a)
        {
            int n = a.Length;
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}] = ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void output(int[] a)
        {
                Console.WriteLine("{0}  ", string.Join(", ", a));
        }
        static void maxPosition(int[] a)
        {
            int n = a.Length;
            int max = a.Max();
            for (int i = 0; i < n; i++)
                if (a[i] == max)
                    Console.Write("{0}  ", i);
            Console.WriteLine();
        }
        static void avgPositiveNum(int[] a)
        {
            int n = a.Length;
            double sum = 0;
            int number = 0;
            for (int i = 0; i < n; i++)
                if (a[i] > 0)
                {
                    sum += a[i];
                    number++;
                }
            Console.WriteLine("Tri trung bình cac phan tu duong co trong day = {0}", (double)sum / number);
        }
        /*
         Do mảng a là một mảng số nguyên nên các phần tử a[i] cũng sẽ là số nguyên
        mặt khác k cũng là số nguyên
        vì vậy khi áp dụng công thức:
         k^n = a[i] => logk(a[i]) = n
        n chắc chắn cũng là 1 số nguyên
         */
        static void countPower(int[] a, int k)
        {
            int n = a.Length;
            int count = 0;
            for (int i = 0; i < n; i++)
                if (Math.Log(a[i], k) == (int)Math.Log(a[i], k)) // lấy logarit cơ số k của a[i]
                    count++;
            Console.WriteLine("So phan tu la luy thua cua {0}: {1}", k, count);
        }
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Nhap so luong phan tu n = ");
                n = int.Parse(Console.ReadLine());
            } while (n < 0);
            int[] a = new int[n];
            input(a);
            Console.WriteLine("Mang vua nhap:");
            output(a);
            Console.WriteLine("Vi tri phan tu lon nhat trong day:");
            maxPosition(a);
            avgPositiveNum(a);
            int k;
            Console.WriteLine("Nhap k = ");
            k = int.Parse(Console.ReadLine());
            countPower(a, k);
            Console.ReadLine();
        }
    }
}
