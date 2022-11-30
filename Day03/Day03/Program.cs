using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Day03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DictionaryChallenge();
            Course pg2 = new Course() { Name = "PG2 - 2212" };

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
                Console.ReadKey();
            }
        }

        private static void DictionaryChallenge()
        {
            Dictionary<string, float> menu;//null

            //3 ways to add data:
            // 1) the initializer
            menu = new Dictionary<string, float>()
            {
                //{key,value} key-value-pair
                { "spaghetti", 15.0F },
                { "Lasagna", 23.0F },
                { "Garlic Bread", 4.99F },
                //{ "Garlic Bread", 6.99F }//will throw an exception
            };
            //2) Add(key,value)
            menu.Add("Pizza Pizza", 10.99F);
            try
            {
                menu.Add("Pizza Pizza", 13.99F);//will throw an exception
            }
            catch(ArgumentException aEX)
            { }
            catch (Exception ex)
            {
            }
            menu.Add("Alfredo Pasta", 18.99F);
            menu.Add("Salad", 8.99F);

            //3) [key] = value
            menu["Soda"] = 1.99F;
            menu["Soda"] = 3.99F;//will NOT throw an exception. will overwrite.
            menu["Sparkling Water"] = 2.99F;
            menu["Chicken Parm"] = 18.99F;
        }
    }
}
