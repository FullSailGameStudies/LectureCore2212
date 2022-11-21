using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    public class Course
    {
        private List<double> _grades;

        public string Name { get; set; } = string.Empty;
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