using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai26
{
    class Program
    {
        static void input(double[,] a)
        {
            int row = a.GetLength(0);
            int col = a.GetLength(1);
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"a[{i}, {j}] = ");
                    a[i, j] = double.Parse(Console.ReadLine());
                }
        }
        static void output(double[,] a)
        {
            int row = a.GetLength(0);
            int col = a.GetLength(1);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                    Console.Write($"{a[i,j]}\t");
                Console.WriteLine();
            }   
        }
        static void evenNum(double[,] a)
        {
            int row = a.GetLength(0);
            int col = a.GetLength(1);
            int count = 0;
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    if ((int)a[i, j] % 2 == 0)
                        count++;
            Console.WriteLine($"Co {count} phan tu co phan nguyen la chan");
        }
        static void mulPositiveElements(double[,] a)
        {
            int row = a.GetLength(0);
            int col = a.GetLength(1);
            int h;
            do
            {
                Console.WriteLine("Nhap hang h: ");
                h = int.Parse(Console.ReadLine());
            } while (h < 0 || h > row - 1);
            double tich = 1;
            for (int i = 0; i < col; i++)
                if (a[h, i] > 0)
                    tich *= a[h, i];
            Console.WriteLine(tich);
        }
        static void sortCol(double[,] a)
        {
            int row = a.GetLength(0);
            int col = a.GetLength(1);
            int c;
            do
            {
                Console.WriteLine("Nhap cot c: ");
                c = int.Parse(Console.ReadLine());
            } while (c < 0 || c > col - 1);
            //sort
            for(int i = 0; i < row - 1; i++)
                for(int j = row - 1; j > i; j--)
                    if(a[j, c] < a[j - 1, c])
                    {
                        a[j, c] += a[j - 1, c];
                        a[j - 1, c] = a[j, c] - a[j - 1, c];
                        a[j, c] -= a[j - 1, c];
                    }
        }
        static void Main(string[] args)
        {
            int row, col;
            do
            {
                Console.WriteLine("Nhap so hang = ");
                row = int.Parse(Console.ReadLine());
            } while (row <= 0);
            do
            {
                Console.WriteLine("Nhap so cot = ");
                col = int.Parse(Console.ReadLine());
            } while (col <= 0);
            double[,] a = new double[row, col];
            input(a);
            Console.WriteLine("Mang vua nhap");
            output(a);
            evenNum(a);
            mulPositiveElements(a);
            sortCol(a);
            output(a);
            Console.ReadKey();
        }
    }
}
