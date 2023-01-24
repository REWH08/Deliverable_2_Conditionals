/*
Author: Roberto Wong Hernandez
Date: 01/19/2023
Description: C# console application to calculate letter grades
*/

using System;
using System.Linq.Expressions;

namespace ISM_4300_Second_Deliverable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a numeric grade: ");

            try
            {
                decimal grade = decimal.Parse(Console.ReadLine());


                if (grade >= 90)
                {
                    Console.WriteLine("Your expected grade in ISM 4300 is A");
                }
                else if (grade >= 80 && grade < 90)
                {
                    Console.WriteLine("Your expected grade in ISM 4300 is B");

                }
                else if (grade >= 70 && grade < 80)
                {
                    Console.WriteLine("Your expected grade in ISM 4300 is C");
                }

                    if (grade >= 60 && grade < 70)
                    {
                        Console.WriteLine("Your expected grade in ISM 4300 is D");
                    }
                    else if (grade >= 50 && grade < 60)
                    {
                        Console.WriteLine("Your expected grade in ISM 4300 is F");
                    }
            }            
            catch
            {
                Console.WriteLine("Please enter a numeric value");        
                      
            }
            


        }

    }


}