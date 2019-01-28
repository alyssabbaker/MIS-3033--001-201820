//Alyssa Baker
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewMethods
{
    class Program
    {
        //static double sum = 0; //class level variable
        static void Main(string[] args)
        {
            //void- not return
            //double- returning values
            double result=Addition(5.5, 2);
            //Console.WriteLine(sum); //since sum is not defined in this method, unable to call it here
            
            double val1 = 10.5;
            double val2 = 1.5;
            Subtraction(val1, val2);
            Console.ReadKey();
        }

        private static void Subtraction(double val1, double val2)
        {
            Console.WriteLine($"{val1-val2}");
        }

        static double Addition(double num1, double num2)
        {
            double sum = num1 + num2;
            return sum;
        }
    }
}
