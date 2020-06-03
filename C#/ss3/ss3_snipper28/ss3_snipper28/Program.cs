using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ss3_snipper28
{
    class Program
    {
        static int Square(object inum)
        {
            return (int)inum * (int)inum;
        }

        static void Main(string[] args)
        {
            int num = 8;
            int result;
            result = Square(num);
            Console.WriteLine("Square of {0} = {1}", num, result);
            Console.Read();
        }
    }
}
