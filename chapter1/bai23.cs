using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai23
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
        static void print(int[] a)
        {
            foreach (int i in a)
                Console.Write("{0}  ", i);
            Console.WriteLine();
        }
        static void output(int[] a)
        {
            Console.WriteLine("{0}", string.Join(", ", a));
        }
        static void reverseOutput(int[] a)
        {
            int[] temp = (int[])a.Clone();
            Array.Reverse(temp);
            output(temp);
        }
        static bool isPrimeNum(int n)
        {
            if (n < 2)
                return false;
            double sqrt_n = Math.Sqrt(n);
            for (int i = 2; i <= sqrt_n; i++)
                if (n % i == 0)
                    return false;
            return true;
        }
        static void countPrimeNum(int[] a)
        {
            int count = 0;
            int n = a.Length;
            for (int i = 0; i < n; i++)
                if (isPrimeNum(a[i]))
                    count++;
            Console.WriteLine("Co {0} phan tu co noi dung la so nguyen to", count);
        }
        static bool isDivisor(int k, int i)
        {
            return k % i == 0;
        }
        static void mulDivisor(int[] a)
        {
            int k;
            int n = a.Length;
            do
            {
                Console.WriteLine("Nhap k = ");
                k = int.Parse(Console.ReadLine());
            } while (k <= 0);
            long result = 1;
            for(int i = 0; i < n; i++)
                if(isDivisor(k, a[i]))
                    result *= a[i];
            Console.WriteLine("Tich cac phan tu la uoc so cua {0} = {1}", k, result);
        }
        static void positionX(int[] a)
        {
            int x;
            Console.WriteLine("Nhap x = ");
            x = int.Parse(Console.ReadLine());
            int m;
            Console.WriteLine("Nhap m = ");
            m = int.Parse(Console.ReadLine());
            int n = a.Length;
            bool flag = false;
            for (int i = 0; i < n && flag == false; i++)
                if (a[i] == x)
                {
                    m--;
                    if (m == 0)
                    {
                        Console.WriteLine(i);
                        flag = true;   
                    }    
                }
            if (flag == false)
                Console.WriteLine("Khong tim thay");
        }
        static void swap(ref int a, ref int b)
        {
            a += b;
            b = a - b;
            a -= b;
        }
        static void Sort(int[]a)
        {
            int n = a.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = n - 1; j > i; j--)
                    if (a[j] > a[j - 1])
                        swap(ref a[j], ref a[j - 1]);
        }

        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("Nhap n = ");
                n = int.Parse(Console.ReadLine());
            } while (n < 0);
            int[] a = new int[n];
            input(a);
            Console.WriteLine("Mang vua nhap (in nguoc):");
            reverseOutput(a);
            countPrimeNum(a);
            mulDivisor(a);
            positionX(a);
            output(a);
            Sort(a);
            output(a);
            Console.ReadLine();
        }
    }
}
