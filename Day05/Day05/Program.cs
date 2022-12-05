using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace Day04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
            List<int> ints = new() { 5, 13, 420, 7, 1 };
            foreach (int i in ints)
                Console.Write($"{i} ");
            Console.WriteLine();
            BubbleSort(ints);
            foreach (int i in ints)
                Console.Write($"{i} ");
            Console.WriteLine();
            Console.ReadKey();

            string s1 = "Batman", s2 = "Bats";
            //CompareTo
            //  -1  means LESS THAN
            //   0  means EQUALS TO
            //   1  means GREATER THAN
            int compResult = s1.CompareTo(s2);
            if (compResult == 0) { Console.WriteLine($"{s1} EQUALS {s2}"); }
            else if (compResult < 0) { Console.WriteLine($"{s1} LESS THAN {s2}"); }
            else if (compResult > 0) { Console.WriteLine($"{s1} GREATER THAN {s2}"); }
            Console.ReadKey();

            for (int i = 0; i < 1000; i++)
            {

            }
            //Console.ReadKey();
            Loopit(0);//i=0
            Console.ResetColor();
            Console.ReadKey();

            string[] menu = new string[]
            {"0. Exit", "1. Part 1 - Bats", "2. Part 2 - Fibonacci", "3. Part 3 - Swap", "4. Part 4 - Split"};

            int part;
            while (true)
            {
                Console.Clear();

                #region Show Menu
                Console.WriteLine("What part to run?");
                foreach (var option in menu)
                    Console.WriteLine(option);
                Console.Write("Choice? ");
                string input = Console.ReadLine();
                #endregion

                if (int.TryParse(input, out part) && part > 0 && part < menu.Length)
                {
                    switch (part)
                    {
                        case 1:
                            Console.WriteLine("Part 1 - Bats");
                            //Add a static Bats method to this file
                            //  convert this for loop to a recursive loop using the Bats method
                            /*
                                for(int i = 0;i < 100;i++)
                                {
                                    Console.Write((char)78);
                                    Console.Write((char)65);
                                    Console.Write(' ');
                                }
                             */
                            //
                            //call Bats here
                            //
                            int i = 0;
                            Bats(i);
                            Console.ResetColor();
                            Console.Write((char)66);
                            Console.Write((char)65);
                            Console.Write((char)84);
                            Console.Write((char)77);
                            Console.Write((char)65);
                            Console.Write((char)78);
                            Console.WriteLine("!");
                            break;
                        case 2:
                            Console.WriteLine("Part 2 - Fibonacci");
                            //Add a static Fibonacci method to this file
                            //  recursively calculate the Fibonacci of a number. 
                            //  EX: Fibonnaci(N) = Fibonnaci(N-1) + Fibonanci(N-2)
                            //      Fibonacci(0) = 0 and Fibonacci(1) = 1

                            //loop 45 times here and call Fibonacci on the for loop variable
                            //  print the result for each call to Fibonacci
                            break;
                        case 3:
                            Console.WriteLine("Part 3 - Swap");
                            //Add a static Swap method to this file
                            //  Parameters: a list of ints and 2 ints for the indexes to swap
                            //  The method should swap the items at the 2 indexes
                            //
                            List<int> numbers = new List<int>() { 5, 7, 1, 3, 13 };
                            int index1 = 1, index2 = 2;
                            //Call Swap from main and pass in a list of ints and 2 indexes to swap
                            //print the list after calling swap to verify that the items were swapped
                            break;
                        case 4:
                            Console.WriteLine("Part 4 - Split");
                            //Add a static Split method to this file
                            //  Parameters: a list of ints
                            //  The method should use the Split portion to create 2 lists from 1 list
                            //  After splitting the list into 2 lists, print the left list and the right list
                            //
                            /*
                                var left := empty list
                                var right:= empty list
                                for i = 0 to length(m) do
                                        if i < (length of m)/ 2 then
                                            add m[i] to left
                                  else
                                    add m[i] to right
                            */

                            //Call Split from main with a list of ints
                            List<int> nums = new() { 5, 7, 1, 3, 13 };
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

        private static void Bats(int i)
        {
            if (i < 100)
            {
                Console.BackgroundColor = (ConsoleColor)randy.Next(16);
                Console.Write((char)78);
                Console.Write((char)65);
                Console.Write(' ');
                Bats(i+1);
            }
        }

        static ulong Factorial(uint N)
        {
            if (N > 1)
                return N * Factorial(N - 1);
            else
                return 1;
        }

        static Random randy = new Random();
        private static void Loopit(int i)
        {
            //exit conditions
            if (i < Console.WindowWidth)
            {
                Console.BackgroundColor = (ConsoleColor)randy.Next(16);
                //Console.SetCursorPosition(randy.Next(Console.WindowWidth),
                //    randy.Next(Console.WindowHeight));
                Console.Write(' ');
                //Thread.Sleep(50);

                Loopit(i + 1);//i++
            }

            Console.BackgroundColor = ConsoleColor.Yellow;
            if (i > 0)
            {
                Console.CursorLeft = i - 1;
                Console.Write(' ');
                //Thread.Sleep(50);
            }
        }

        public static void BubbleSort(List<int> unsorted)//classes are reference types
        {
            int numberOfItems = unsorted.Count;
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 1; i <= numberOfItems-1; i++)
                {
                    if (unsorted[i - 1] > unsorted[i])//items in wrong order
                    {
                        //swap(A[i - 1], A[i]);
                        //int temp = A[i - 1];
                        //A[i - 1] = A[i];
                        //A[i] = temp;
                        (unsorted[i], unsorted[i - 1]) = (unsorted[i - 1], unsorted[i]);
                        swapped = true;
                    }
                }
                --numberOfItems;
            } while (swapped);
        }
    }
}
