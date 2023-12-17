using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    class clsTypeCasting
    {
        static void Main(string[] args)
        {
            // type casting = Converting a value to a different data type 
            //                Useful when we accept user input (string) 
            //                Different data types can do different things


            double a = 3.14;
            int b = Convert.ToInt32(a);
            Console.WriteLine(b);
            Console.WriteLine(b.GetType());

            int c = 123;
            double d = Convert.ToDouble(c) + 0.1;
            Console.WriteLine(d);
            Console.WriteLine(d.GetType());

            int e = 321;
            String f = Convert.ToString(e);
            Console.WriteLine(f);
            Console.WriteLine(f.GetType());

            String g = "$";
            char h = Convert.ToChar(g);
            Console.WriteLine(h);
            Console.WriteLine(h.GetType());


            String i = "true";
            bool j = Convert.ToBoolean(i);
            Console.WriteLine(j);
            Console.WriteLine(j.GetType());

            Console.Read();
        }
    }
}
