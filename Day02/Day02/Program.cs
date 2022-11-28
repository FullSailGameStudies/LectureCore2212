using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Day02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayChallenge();
            Course pg2 = new Course() { Name = "PG2 - 2212" };

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
                            pg2.FillGrades();
                            break;
                        case 2:
                            //Add a method PrintGrades to the Course class
                            //  loop over the _grades list
                            //      print each grade
                            //call PrintGrades here
                            pg2.PrintGrades();
                            break;
                        case 3:
                            //Add a method DropFailing to the Course class
                            //  loop over the _grades list
                            //      remove the grade if it's < 59.5
                            //  return the number of grades removed
                            //call DropFailing here and print the number of grades removed
                            //call PrintGrades here
                            int numDropped = pg2.DropFailing();
                            pg2.PrintGrades();
                            Console.WriteLine($"Dropped {numDropped} grades.");
                            break;
                        case 4:
                            //Add a method CurveGrades(amount) to the Course class
                            //  clone the _grades list
                            //  loop over the cloned list
                            //      curve the grades (add the amount to each grade)
                            //  return the curved list
                            //call CurveGrades here 
                            List<double> curved = pg2.CurveGrades(5);
                            pg2.PrintGrades(curved);
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
                Console.ReadKey();
            }
        }

        private static void ArrayChallenge()
        {
            string superNames = "Batman,Wonder Woman,Superman,,Aquaman;Joker;;;Riddler;Penguin;GorrilaGrodd;";

            char[] delimiters = new char[] { ',', ';' };
            string[] supes = superNames.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);// new string[4] { "Batman", "Wonder Woman", "Superman", "Aquaman" };
            for (int i = 0; i < supes.Length; i++)
            {
                Console.WriteLine($"{i+1}.{supes[i]}");
            }

            //to clone an array or List
            List<string> clone1 = supes.ToList();
            List<string> clone2 = new List<string>(supes);

            //resizing is a "pain"
            string[] temp = new string[supes.Length + 1];
            for (int i = 0; i < supes.Length; i++)
            {
                temp[i] = supes[i];
            }
            temp[temp.Length - 1] = "Green Lantern";
            supes = temp;

            List<string> supers = new List<string>();// { "Batman" };
            PrintDetails(supers);
            supers.Add("Superman");
            PrintDetails(supers);//Count:  Capacity: 
            supers.Add("Wonder Woman");
            supers.Add("Aquaman");
            supers.Add("Aquaman");
            supers.Add("Green Latern");//Count:4  Capacity: 4
            supers.Add("Flash");
            PrintDetails(supers);//Count:5  Capacity: ?
            supers.Add("Martian Man Hunter");
            supers.Add("Shazam");
            supers.Add("Cyborg");
            supers.Add("Beast Boy");//Count:9  Capacity: 16
            PrintDetails(supers);
            supers.Remove("Aquaman");
            supers.RemoveAt(2);

            List<string> JLA = supers;//NOT a clone


            Console.WriteLine("List of Superheroes");
            for (int i = 0; i < supers.Count; i++)
            {
                Console.WriteLine(supers[i]);
            }

            Console.ReadKey();
        }
        static void PrintDetails(List<string> best)
        {
            //Count: # of items that have been added
            //Capacity: Length of the internal array
            Console.WriteLine($"Count: {best.Count}\tCapacity: {best.Capacity}");
        }
    }
}
