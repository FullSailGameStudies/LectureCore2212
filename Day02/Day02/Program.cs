using System;
using System.Collections.Generic;
using System.Linq;

namespace Day02
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
                Console.Write("What part to run?\n0. Exit\n1. Part 1 - Creating and Adding\n2. Part 2 - Looping\n3. Part 3 - Removing\n4. Part 4 - Cloning\n5. Split\n6. Extras\nChoice? ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out part) && part > 0 && part < 6)
                {
                    switch (part)
                    {
                        case 1:
                            //Add a method FillGrades to the Course class
                            //  Initialize the _grades list
                            //  add 10 random grades 
                            //call FillGrades here 
                            break;
                        case 2:
                            //Add a method PrintGrades to the Course class
                            //  loop over the _grades list
                            //      print each grade
                            //call PrintGrades here
                            break;
                        case 3:
                            //Add a method DropFailing to the Course class
                            //  loop over the _grades list
                            //      remove the grade if it's < 59.5
                            //  return the number of grades removed
                            //call DropFailing here and print the number of grades removed
                            //call PrintGrades here
                            break;
                        case 4:
                            //Add a method CurveGrades(amount) to the Course class
                            //  clone the _grades list
                            //  loop over the cloned list
                            //      curve the grades
                            //  return the curved list
                            //call CurveGrades here 
                            break;
                        case 5:
                            //Add a PrintData(string) method to the SplitText class
                            //  splits the parameter
                            //  print the array items
                            break;
                        case 6:
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
