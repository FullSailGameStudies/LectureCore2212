using System;
using System.Collections.Generic;
using System.Linq;

namespace Day03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course pg2 = new Course() { Name = "PG2 - 2211" };

            while (true)
            {
                Console.Clear();
                int part = 1;
                Console.Write("What part to run?\n0. Exit\n1. Part 1 - Creating and Adding\n2. Part 2 - Looping\n3. Part 3 - Removing\n4. Part 4 - Cloning\n5. Extras\nChoice? ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out part) && part > 0 && part < 6)
                {
                    switch (part)
                    {
                        case 1:
                            //Add a method FillGrades to the Course class
                            //  initialize the dictionary
                            //  add students and grades
                            //call FillGrades here 
                            break;
                        case 2:
                            //Add a method PrintGrades to the Course class
                            //  loop over dictionary 
                            //      print student name and grade
                            //call PrintGrades here
                            break;
                        case 3:
                            //Add a DropStudent method to the Course class
                            //  loop
                            //      ask for the name of the student to drop
                            //      call Remove to remove the student
                            //      print message indicating what happened
                            //          error message if not found
                            //      else call printgrades and print that the student was removed
                            break;
                        case 4:
                            //Add a CurveStudent method to the Course class
                            //  loop
                            //      ask for the name of the student to curve
                            //      if student found
                            //          curve grade
                            //          call PrintGrades
                            //      else
                            //          print error message
                            break;
                        case 5:
                            ExtraChallenges.Run();
                            break;
                        default:
                            break;
                    }
                }
                else
                    break;
            }
        }
    }
}
