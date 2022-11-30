using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    public class Course
    {
        private Dictionary<string, double> _grades;
        private List<string> roster = new List<string>()
        {
            "Ethan", "Shaun", "Jason", "Parker", "Adam", "Gustavo",
            "Anthony", "Johnathan", "Zoleda", "Kemarly", "Taylor",
            "Joshua", "Josiah", "Steven", "Jordan", "Jacob",
            "Christopher", "Carlos", "Derrick", "Victor", "Julio",
            "Colyn", "Christian", "Cameron", "Daniel", "Trinity",
            "George", "Douglas", "Chase", "Steve", "Jymeer", "Xavier",
            "Tameka", "Quintin", "Josh"
        };

        public string Name { get; set; } = String.Empty;

        public void FillGrades()
        {
            _grades = new Dictionary<string, double>();
            Random randy = new Random();
            foreach (string student in roster)
            {
                _grades.Add(student, randy.NextDouble() * 100);
            }
        }

        public void PrintGrades()
        {
            if (_grades == null) FillGrades();

            Console.WriteLine($"---------grades for {Name}--------");
            foreach (KeyValuePair<string,double> gradeKVP in _grades)
            {
                Console.Write($"{gradeKVP.Key}");
                Console.CursorLeft = 10;
                double grade = gradeKVP.Value;

                if (grade < 59.5) Console.ForegroundColor = ConsoleColor.Red;
                else if (grade < 69.5) Console.ForegroundColor = ConsoleColor.DarkYellow;
                else if (grade < 79.5) Console.ForegroundColor = ConsoleColor.Yellow;
                else if (grade < 89.5) Console.ForegroundColor = ConsoleColor.Blue;
                else Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine($"{gradeKVP.Value,7:N2}");

                Console.ResetColor();
            }
        }

        public void DropStudents()
        {
            if (_grades == null) FillGrades();
            PrintGrades();
            do
            {
                Console.Write("Student to drop: ");
                string student = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(student)) break;

                bool wasDropped = _grades.Remove(student);
                if(wasDropped)
                {
                    PrintGrades();
                    Console.WriteLine($"{student} was dropped.");
                }
                else
                    Console.WriteLine($"{student} was not on the roster.");
            } while (true);
        }
    }
}

//create a method called FillGrades
//  initialize the dictionary
//  add students and grades

//create a PrintGrades method
//  loop over dictionary and print student name and grade

//create a DropStudent method
//  loop
//      ask for the name of the student to drop
//      call Remove to remove the student
//      print message indicating what happened
//          error message if not found
//      else call printgrades and print that the student was removed


//create a CurveStudent method
//  loop
//      ask for the name of the student to curve
//      if student found
//          curve grade
//          call PrintGrades
//      else
//          print error message
