using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_ConditionalsLoopsCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //CONDITIONALS
            // int age=0;
            // Console.WriteLine("Please enter yo age: ");
            // age = Convert.ToInt32(Console.ReadLine());
            // if(age==18)
            // {
            //     Console.WriteLine("Congratz, you are 18.");
            // }
            // if (age==16)
            // {
            //     Console.WriteLine("vroom vrrom, you can drive.");
            // }

            //// Console.WriteLine("Your age is " + age.ToString("N0")); //CONCATENATE A STRING W THE VALUE OF OUR VARIABLE 'AGE' FORMULATES AS A NUMBER

            //LOOPS
            //for (int i = 100; i >=0; i--)
            //{
            //    if (i==0)
            //    {
            //        Console.WriteLine("BLAST OFF");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            //int i = 100;
            //do
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}
            //while (i >= 0);

            //COLLECTIONS
            //string[] firstNames = new string[15];
            //string[] lastNames = new string[15];
            //firstNames[0] = "Alyssa";
            //lastNames[0] = "Baker";
            //firstNames[1] = "Steve";
            //lastNames[1] = "Jobs";
            //for(int i =0; i<firstNames.Length;i++)
            //{
            //    //if(lastNames[i]==null && firstNames[i]==null)
            //    //{

            //    //}
            //    //else
            //    //{
            //    //    Console.WriteLine($"{lastNames[i]},{firstNames[i]}");
            //    //}
            //    //Console.WriteLine($"{lastNames[i]},{firstNames[i]}");

            //    if (lastNames[i] != null && firstNames[i] != null)
            //    {
            //        Console.WriteLine($"{lastNames[i]},{firstNames[i]}");
            //    }
            //}
            // NEW
            //List<double> examScores = new List<double>();
            //examScores.Add(75.5);
            //examScores.Add(50);
            //examScores.Add(25.5);
            //examScores.Add(7);
            //examScores.Add(100);
            //double average = 0; //Accumulating variable
            //foreach (var item in examScores)
            //{
            //    average += item;
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine($"Your average exam score is {(average / examScores.Count).ToString("N2")}");

            //NEW
            Dictionary<int, double> studentGrades = new Dictionary<int, double>();
            studentGrades.Add(1, 0.97);
            studentGrades.Add(2, 0.47);
            studentGrades.Add(0,0.5);
            Console.WriteLine(studentGrades[1].ToString("P2")); //PERCENT W 2 DECIMAL PLACES
            if(studentGrades.ContainsKey(0)==true)
            {
                //Console.WriteLine(studentGrades[0]);
            }
            else
            {
                studentGrades.Add(0, 1.0);
            }
            Console.WriteLine(studentGrades[0]);


            Console.ReadKey();
        }
    }
}
