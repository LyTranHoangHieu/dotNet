using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai9
{
    class Program
    {
        static void Main(string[] args)
        {
            for (char i = '0'; i <= '9'; i++)
                Console.WriteLine("'{0}' : {1}", i, (int)i);
            for (char i = 'a'; i <= 'z'; i++)
                Console.WriteLine("'{0}' : {1}", i, (int)i);
            Console.ReadLine();
        }
    }
}
