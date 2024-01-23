using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    class clsArrays
    {
        static void Main(string[] args)
        {
            // array = a variable that can store multiple values. fixed size

            String[] cars = new String[3];

            // String[] cars = { "BMW", "Mustang", "Corvette" };

            cars[0] = "Toyota";
            cars[1] = "Mustang";
            cars[2] = "Lamborghini";

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            Console.ReadKey(); 
        }
    }
}
