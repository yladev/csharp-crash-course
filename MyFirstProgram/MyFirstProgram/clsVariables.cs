using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    class clsVariables
    {
        static void Main(string[] args)
        {
            int x; // declaration
            x = 123; // initialization

            int y = 321; // declaration + initialization

            int z = x + y;

            int age = 18; // whole integer
            double height = 168.8; // decimal number
            bool alive = true; // true or falseh
            char symbol = '@'; // only one character
            String name = "Jason";

            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("z = " + z);
            Console.WriteLine("Hello " + name);
            Console.WriteLine("My age is " + age);
            Console.WriteLine("My height is " + height + "cm");
            Console.WriteLine("Are you alive?" + alive);
            Console.WriteLine("My symbol is: " + symbol);

            String userName = name + symbol;
            Console.WriteLine("Your username is: " + userName);
            Console.Read();
        }
    }
}
