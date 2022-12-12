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

        public JobPosition Position { get; private set; } = JobPosition.Intern;

        public void Promotion(JobPosition newPosition)
        {
            Position = newPosition;
            Position.SetColor();
            switch (Position)
            {
                case JobPosition.Intern:
                    Console.WriteLine("I'm a lowly intern! Let me get you some coffee.");
                    break;
                case JobPosition.JuniorDeveloper:
                    Console.WriteLine("I got a job dad!");
                    break;
                case JobPosition.Developer:
                    Console.WriteLine("I can't believe they promoted me.");
                    break;
                case JobPosition.SeniorDeveloper:
                    Console.WriteLine("I'm a GOD!!!!!");
                    break;
                case JobPosition.LeadDeveloper:
                    Console.WriteLine("Just let me do it. Get out of my way.");
                    break;
                case JobPosition.VicePresident:
                    Console.WriteLine("I forgot everything about programming. Listen to me now!");
                    break;
                case JobPosition.President:
                    Console.WriteLine("Don't talk to me. You are beneath me.");
                    break;
                case JobPosition.CEO:
                    Console.WriteLine("I make 10 million times more than you do. I'm going on vacation.");
                    break;
                default:
                    break;
            }
            Console.ResetColor();
        }
    }
}
