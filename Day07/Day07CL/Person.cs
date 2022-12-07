using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class Person
    {
        #region Fields
        private int _age;
        #endregion

        //
        //add a property to gatekeep the age field
        //
        public int Age 
        { 
            get { return _age; } 
            set { 
                if(value >= 0 && value < 122)
                    _age = value; 
            } 
        }

        // add an auto-prop for a Name
        public string Name { get; private set; }

        // add a constructor
        //      initialize the age and name
        public Person(int age, string fullName)
        {
            Name = fullName;
            Age = age;
        }



    }
}
