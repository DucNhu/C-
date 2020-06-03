using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ss2_snipper10
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Windows\\MyFile.txt";
            bool found = true;
            if (found)
            {
                Console.WriteLine("File path: \'" +path + "\'");
            }
            else
            {
                Console.WriteLine("File Not Found!\a");
            }

            Console.Read();

        }
    }
}
