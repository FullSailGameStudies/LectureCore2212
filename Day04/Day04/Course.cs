using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    public class Course
    {
        private Dictionary<string, double> _grades;

        public string Name { get; set; } = String.Empty;

        public Course()
        {
            FillGrades();
        }

        public void SaveGrades()
        {
            string filePath = "coursegrades.csv";
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                char delimiter = '^';
                foreach (var grade in _grades)
                {
                    sw.Write(grade.Key);
                    sw.Write(delimiter);
                    sw.WriteLine(grade.Value);
                }
            }
        }

        public void LoadGrades()
        {
            _grades.Clear();
            string filePath = "coursegrades.csv";
            if (File.Exists(filePath))
            {
                string fileData = File.ReadAllText(filePath);
                string[] kvps = fileData.Split('\n', StringSplitOptions.RemoveEmptyEntries);
                foreach (var kvp in kvps)
                {
                    string[] keyValue = kvp.Split('^');
                    if (double.TryParse(keyValue[1], out double grade))
                    {
                        _grades[keyValue[0]] = grade;
                    }
                }
            }
        }



        #region Day03 Code
        public void FillGrades()
        {
            List<string> students = new List<string>()
            {
                "Anthony", "Julio", "Jeffrey", "ID", "Jonah", "Jake", "Jesus", "Sam",
                "Albert", "Hanna", "Connor", "Aidan", "Carter", "Alexis", "Kemarly",
                "Joaquin", "Enrique"
            };
            Random rando = new Random();
            _grades = new Dictionary<string, double>();
            _grades.Add("Steev", rando.NextDouble() * 100);
            _grades.Add("Anita", rando.NextDouble() * 100);
            _grades.Add("Cameron", rando.NextDouble() * 100);
            _grades.Add("dylan", rando.NextDouble() * 100);
            _grades.Add("Frankie", rando.NextDouble() * 100);
            _grades.Add("Japhet", rando.NextDouble() * 100);
            foreach (var student in students)
            {
                _grades[student] = rando.NextDouble() * 100;
            }
        }
        public void PrintGrades()
        {
            if (_grades == null) FillGrades();
            Console.WriteLine($"---------{Name}----------");
            foreach (var student in _grades)
            {
                string name = student.Key;
                double grade = student.Value;
                Console.ForegroundColor = (grade < 59.5) ? ConsoleColor.Red :
                                          (grade < 69.5) ? ConsoleColor.DarkYellow :
                                          (grade < 79.5) ? ConsoleColor.Yellow :
                                          (grade < 89.5) ? ConsoleColor.Blue :
                                          ConsoleColor.Green;
                Console.Write($"{grade,7:N2} ");
                Console.ResetColor();
                Console.WriteLine(name);
            }
        }
        public void DropStudent()
        {
            if (_grades == null) FillGrades();
            do
            {
                PrintGrades();
                Console.Write("Student to drop? ");
                string student = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(student)) break;

                bool wasDropped = _grades.Remove(student);
                if (wasDropped)
                {
                    PrintGrades();
                    Console.WriteLine($"{student} was dropped from {Name}.");
                }
                else
                    Console.WriteLine($"{student} was not in {Name}.");
            } while (true);
        }
        public void CurveStudent()
        {
            if (_grades == null) FillGrades();
            do
            {
                PrintGrades();
                Console.Write("Student to curve? ");
                string student = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(student)) break;

                if (_grades.TryGetValue(student, out double grade))
                {
                    _grades[student] = Math.Min(100, grade + 5);
                    PrintGrades();
                    Console.WriteLine($"{student} was curved from {grade} to {_grades[student]}.");
                }
                else
                    Console.WriteLine($"{student} was not in {Name}.");
            } while (true);
        }
        #endregion
    }
}