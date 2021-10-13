// Author: Tichaona Gangaidzo 
//Date: 10/12/2021
//Description: Using C# conditional statements to output a letter grade once the user inputs an integer grade of what they think they will get for a class



using System;

namespace Tech_project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What grade do you expect to get in ISM 4300?");
            //Start of the try-catch statement
            
            try
            {
                // declaring the variables 
                string input = Console.ReadLine();
                int grades = int.Parse(input);

                // else if statement for if the integer grade input is 0-59 the output would be a F
                if (grades < 60)
                {
                    Console.WriteLine("Your letter grade for this course would be an F. ");

                }
                // else if statement for if the integer grade input is 60-69 the output would be a D
                else if ((grades>59) && (grades<70))
                {
                    Console.WriteLine("Your letter grade for this course would be a D.");

                }
                //else if statement for if the integer grade input is 70-79 the output would be a C 
                else if((grades >69) && (grades<80))
                {
                    Console.WriteLine("Your letter grade for this course would be a C.");
                }
                // else if statement for if the integer grade input is 80-89 the output would be a B
                else if ((grades>79) && (grades<90))
                {
                    Console.WriteLine("Your letter grade for this ccourse would be a B.");

                }
                // else if statement for if the integer grade input is 90-100 the output would be an A
                else if ((grades>89) && (grades<=100))
                {
                    Console.WriteLine("Your letter grade for this course is an A.");

                }
                Console.ReadKey(true);
            }
            //Catch statement 
            catch
            {
                Console.WriteLine("Please enter an integer grade value between 0 and 100.");
                Console.ReadKey(true);
            }
        }
    }
}
