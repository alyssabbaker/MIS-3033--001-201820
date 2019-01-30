using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world.");
            Student alyssa = new Student();
            alyssa.FirstName = "Alyssa";
            alyssa.LastName = "Baker";
            Student tim = new Student(3, "Timothy", "Fisher", 80000.5);

            Console.ReadKey();
        }
    }
}
