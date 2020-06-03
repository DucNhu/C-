using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ss3_snipper23_24
{
    class Program
    {
        static void Main(string[] args)
        {
            //Snipper23
            double side = 10.5;
            int area;
            area = (int)(side * side);
            Console.WriteLine("Area of the square = {0}", area);

            //Snipper24
            float flotNum = 500.25F;
            string stNum = flotNum.ToString();
            Console.WriteLine(stNum);
            Console.Read();

        }
    }
}
