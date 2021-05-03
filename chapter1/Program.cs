using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            double myDouble;
            decimal myDecimal;
            float myFloat;
            myDouble = 3.14d;
            myDecimal = 3.14m;
            myFloat = 3.14f;
            Console.WriteLine("My Double: {0}", myDouble);
            Console.WriteLine("My Decimal: {0}", myDecimal);
            Console.WriteLine("My Float: {0}", myFloat);
            Console.ReadLine();
        }
    }
}
