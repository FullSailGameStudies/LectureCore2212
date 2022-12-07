using System;
using System.Collections.Generic;
using System.Linq;

namespace Day06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new() { 5, 13, 420, 73, 10005 };
            int number = 735;
            int index = LinearSearch(numbers, number);//returns -1
            PrintResults(index, number);
            number = 10005;
            index = LinearSearch(numbers, number);//returns -1
            PrintResults(index, number);

        }

        private static void PrintResults(int index, int number)
        {
            if(index < 0)
                Console.WriteLine($"{number} was not found.");
            else
                Console.WriteLine($"{number} was found at index {index}.");
        }

        private static int LinearSearch(List<int> numbers, int numberToFind)
        {
            int foundIndex = -1;
            for (int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] == numberToFind)
                {
                    foundIndex = i;
                    break;
                }
            }
            return foundIndex;
        }
    }
}
