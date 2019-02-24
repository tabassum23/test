using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test123
{
    class Program
    {
        static void Main(string[] args)
        {
            //    for (int i = 1; i <=25; i++)
            //    {
            //        if (i % 3 ==0)
            //        {
            //            continue;
            //        }
            //        Console.WriteLine(i);
            //    }
            //    Console.ReadLine();

            //}
            //int r;
            //double a;
            //const double pi = 3.14;
            //Console.Write("Enter the radius: ");
            //r = Convert.ToInt32(Console.ReadLine());
            //a = pi * r * r;
            //Console.WriteLine("Area of circle is = " + a);
            //Console.ReadLine();

            
            Console.WriteLine("Enter a number: ");
            //Console.ReadLine();
            string NumberInStringFormat = Console.ReadLine();
            int NumberInIntFormat = Convert.ToInt32(NumberInStringFormat);
            if (NumberInIntFormat % 2 == 0)
            {
                Console.Write("The Number entered is Even");
                Console.Read();
            }
            else
            {
                Console.Write("The Number entered is odd");
                Console.Read();
            }
        }
    }
}

/*
 1. Take a number from user and inform whether that is EVEN or ODD number
 2. calculator

    int i;
    Console.WriteLine(
 //Q) identify whether given number is even or odd WITHOUT USING ANY CONDITIONAL STATEMENTS

     * /



