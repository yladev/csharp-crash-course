using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    class clsArithmeticOperators
    {
        static void Main(string[] args)
        {
            int friends = 10;
            // friends = friends + 2; (frist way)
            // friends += 2; (second way)
            // friends++; (third way within loop)

            // friends = friends - 1;
            // friends -= 1;
            // friends--;

            // friends = friends * 2;
            // friends *= 2;

            // friends = friends / 2;
            // friends /= 2;

            int remainder = friends % 3;

            Console.WriteLine(remainder);
            Console.ReadKey();
        }
    }
}
