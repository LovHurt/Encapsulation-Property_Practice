using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Property_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();

            e1.TRIDNUMBER = "12345678904";

            Console.WriteLine("Your TR ID Number : " +e1.TRIDNUMBER);
        }
    }
}
