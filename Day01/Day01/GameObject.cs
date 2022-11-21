using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    public class GameObject
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Symbol { get; set; }
        public ConsoleColor Fore { get; set; }
        public ConsoleColor Back { get; set; }

        public void DrawMe()
        {
            Console.SetCursorPosition(X, Y);
            Console.ForegroundColor = Fore;
            Console.BackgroundColor = Back;
            Console.Write(Symbol);
            Console.ResetColor();
        }

        public void MoveRight()
        {
            if (X < Console.WindowWidth - 1)
                X++;
            else 
                X = 0;
        }
        public void MoveLeft()
        {
            if (X > 0)
                X--;
            else
                X = Console.WindowWidth - 1;
        }

        public void MoveDown()
        {
            if (Y < Console.WindowHeight - 1)
                Y++;
            else
                Y = 0;
        }
        public void MoveUp()
        {
            if (Y > 0)
                Y--;
            else
                Y = Console.WindowHeight - 1;
        }
    }
}
