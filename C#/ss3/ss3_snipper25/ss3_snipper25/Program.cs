using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ss3_snipper25
{
    class Program
    {
        static void Main(string[] args)
        {
            int radius = 10;
            double area;
            area = 3.14 * radius * radius;
            object boxed = area;
            Console.WriteLine("Area of the circle = { 0}",boxed);
            Console.Read();
        }
    }
}
