using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    class clsRandomNumbers
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            // int x = random.Next(1, 7);
            // double num = random.NextDouble();

            int num = random.Next(1, 7);
            int num2 = random.Next(1, 7);
            int num3 = random.Next(1, 7);

            Console.WriteLine(num);
            Console.WriteLine(num2);
            Console.WriteLine(num3);

            Console.ReadKey();
        }
    }
}
