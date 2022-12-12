using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public static class Extensions
    {
        public static void SetColor(this JobPosition position)
        {
            switch (position)
            {
                case JobPosition.Intern:
                    Console.BackgroundColor = ConsoleColor.Gray;
                    break;
                case JobPosition.JuniorDeveloper:
                    Console.BackgroundColor = ConsoleColor.White;
                    break;
                case JobPosition.Developer:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    break;
                case JobPosition.SeniorDeveloper:
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    break;
                case JobPosition.LeadDeveloper:
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                case JobPosition.VicePresident:
                    Console.BackgroundColor = ConsoleColor.Green;
                    break;
                case JobPosition.President:
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    break;
                case JobPosition.CEO:
                    Console.BackgroundColor = ConsoleColor.Blue;
                    break;
                default:
                    break;
            }
        }
    }
}
