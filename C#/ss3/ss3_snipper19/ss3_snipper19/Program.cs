using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ss3_snipper19
{
    class Program
    {
        static void Main(string[] args)
        {
            uint num = 10;
            uint result = num << 1;
            Console.WriteLine("Value before left shift : " + num);
            Console.WriteLine("Value after left shift " + result);
            num = 80;
            result = num >> 1;
            Console.Read();
        }
    }
}
