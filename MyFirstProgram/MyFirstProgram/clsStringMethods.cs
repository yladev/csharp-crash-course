using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    class clsStringMethods
    {
        static void Main(string[] args)
        {
            String fullName = "Jason Andrew";
            fullName = fullName.ToUpper();
            fullName = fullName.ToLower();
            Console.WriteLine("My name is " + fullName);

            String phoneNumber = "09-254488150";
            phoneNumber = phoneNumber.Replace("0", "9");
            Console.WriteLine(phoneNumber);

            String userName = fullName.Insert(0, "Mr.");
            Console.WriteLine(userName);

            Console.WriteLine(fullName.Length);

            Console.ReadKey();
        }
    }
}
