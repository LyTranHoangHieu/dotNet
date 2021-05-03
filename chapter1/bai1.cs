using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            for (x = 1; x < 10; x++)
                System.Console.WriteLine("{0:03}", x);
            Console.ReadLine();
        }
    }
}
