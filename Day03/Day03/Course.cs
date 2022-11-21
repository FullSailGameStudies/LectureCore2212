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

        public string Name { get; set; } = String.Empty;
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
