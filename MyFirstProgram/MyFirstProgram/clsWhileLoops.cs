using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    class clsWhileLoops
    {
        static void Main(string[] args)
        {
            // while loop = repeats some code while some condition remains true
            String name = "";

            while (name == "")
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
            }

            Console.WriteLine("Hello " + name);

            /* while (1 == 1)
            {
                Console.WriteLine("HELP! I'm STUCK IN AN INFINITE LOOP!");
            } */

            Console.ReadKey();
        }
    }
}