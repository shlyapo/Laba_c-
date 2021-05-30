using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Number a = new Number() { N = 7, M = 19 };
            Number b = new Number() { N = 12, M = 21 };

            Number res = a - b;

            Console.WriteLine(res.ToString());
            Console.Read();
        }
    }
}
