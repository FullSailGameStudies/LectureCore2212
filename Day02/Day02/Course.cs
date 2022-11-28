using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    public class Course
    {
        private List<double> _grades = new List<double>(10);

        public string Name { get; set; } = string.Empty;

        public void FillGrades()
        {
            //_grades = new List<double>();//initialize my list
            Random rando = new Random();
            for (int i = 0; i < 10; i++)
            {
                _grades.Add(rando.NextDouble() * 100);
            }
        }

        public void PrintGrades(List<double> gradesToPrint = null)
        {
            if (gradesToPrint == null) gradesToPrint = _grades;
            //$ - interpolated string
            Console.WriteLine($"Grades for {Name}");
            for (int i = 0; i < gradesToPrint.Count; i++)
            {
                Console.WriteLine(gradesToPrint[i]);
            }
        }

        public int DropFailing()
        {
            int numberDropped = 0;
            //for (int i = 0; i < _grades.Count; i++)
            //{
            //    if (_grades[i] < 59.5)
            //    {
            //        numberDropped++;
            //        _grades.RemoveAt(i);
            //        i--;
            //    }
            //}
            //reverse for loop
            for (int i = _grades.Count - 1; i >= 0; i--)
            {
                if (_grades[i] < 59.5)
                {
                    numberDropped++;
                    _grades.RemoveAt(i);
                }
            }
            return numberDropped;
        }

        public List<double> CurveGrades(int amount)
        {
            List<double> clone = _grades.ToList();
            for (int i = 0; i < clone.Count; i++)
            {
                //C# ternary operator
                clone[i] = (clone[i] + amount <= 100) ? clone[i] + amount : 100;
            }
            return clone;
        }
    }
}


//create a method FillGrades
//  Initialize the _grades list
//  add 10 random grades 
//  call FillGrades from Main

//create a method PrintGrades()
//  loop over the _grades list
//      print each grade
//  call PrintGrades from Main

//Create a method DropFailing
//  loop over the _grades list
//      remove the grade if it's < 59.5
//  return the number of grades removed
//  call DropFailing from Main and print the results
//  call PrintGrades from Main

//Create a method CurveGrades(amount)
//  clone the _grades list
//  loop over the cloned list
//      curve the grades
//  return the curved list
//  call CurveGrades from Main 

//create a static PrintGrades(list)
//  call the static version from PrintGrades
//  call the static version from Main to print the curved grades