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

        #region Properties
        //
        //add a property to gatekeep the age field
        //
        public int Age
        {
            get { return _age; }
            set
            {
                if (value >= 0 && value < 122)
                    _age = value;
            }
        }

        // add an auto-prop for a Name
        public string Name { get; private set; }

        #endregion

        // add a constructor
        //      initialize the age and name
        public Person(int age, string fullName)
        {
            Name = fullName;
            Age = age;
        }

        //write an ItsMyBirthday method
        //  increment age and print out a happy message
        public void ItsMyBirthday()
        {
            Age++;
            Console.WriteLine("😁It's my birthday!! WOOT!! WOOT!! 🎂");
        }

        //
        // 1) create an enum for job position (Intern, JuniorDeveloper, Developer, SeniorDeveloper, LeadDeveloper, VicePresident, President, CEO
        // 2) add a property to store the person position
        // 3) create a Promotion method.
        //      pass in a parameter for the new position
        //      update the property and print out the new position

    }
}
