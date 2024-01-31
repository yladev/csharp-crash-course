using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    class clsMethods
    {
        static void Main(string[] args)
        {
            // method = performs a section of code, whenever it's called "invoked".
            //          benefit = Let's us reuse code w/o writing it multiple times.


            String name = "Jason";
            int age = 18;

            singHappyBirthday(name, age);

            Console.ReadKey();
        }

        static void singHappyBirthday(string name, int age)
        {
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday dear " + name);
            Console.WriteLine("You are " + age + " years old!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine();
        }
    }
}
