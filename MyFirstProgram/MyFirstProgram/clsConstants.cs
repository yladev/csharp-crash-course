using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    class clsConstants
    {
        static void Main(string[] args)
        {
            // constants = immutable values which are known at compile time and do not change for the life of the program

            const double pi = 3.1415;

            Console.WriteLine("pi value: " + pi);
            Console.Read();
        }
    }
}
