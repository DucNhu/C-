using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ss3_snipper3
{
    class Program
    {
        static void Main(string[] args)
        {
            int side = 5;
            int height = 10;
            double area;
            {
                area = 0.5 * side * height;
            }
            Console.WriteLine(area);
            Console.Read();
        }
    }
}
