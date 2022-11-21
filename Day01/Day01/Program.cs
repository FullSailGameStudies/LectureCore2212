using System;

namespace Day01
{

    //Day 01

    //METHODS
    //- call DrawBlock

    //Pass by Value
    //- add DrawBlock overload that takes an x, y, color params
    //- call new DrawBlock method


    //Pass by Ref
    //- GetCursorPosition(ref x, ref y)


    //Out param
    //- GetWindowBounds(out width, out height)


    //optional param
    //- SetColors(foreground, background = black)

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Variable basics
            //<type> <name>
            int age = 12;

            //Method basics: return type, parameters
            int sum = Add(5, 2);
            int n1 = 15, n2 = 420;

            //Parameters: Pass by Value (COPY)
            sum = Add(n1, n2);//n1 is COPIED to num1

            //Parameters: Pass by Reference

            //Parameters: Out Parameters

            //Parameters: optional parameters

            LectureChallenges();

            Console.ReadKey(true);
        }

        static int Add(int num1, int num2)
        {
            //int num1 = 5, num2 = 2;
            return num1 + num2;
        }

        static void LectureChallenges()
        {
            Console.Clear();
            Console.WriteLine("Lecture Code Challenges...");

            InitObjects();
            DrawObjects();

            Console.SetCursorPosition(0, 4);
            Console.WriteLine("Press any key to start your code.");

            _deadpool.Fore = ConsoleColor.White;
            _deadpool.Back = ConsoleColor.Red;
            _deadpool.DrawMe();

            Console.ReadKey(true);
            //-------------------------------------------------------------------------------------------
            //
            // PART 1: Calling Methods
            //
            //      Add code to move _deadpool to the goal using the Move methods of the GameObject class.
            //
            //-------------------------------------------------------------------------------------------
            for (int i = 0; i < 6; i++)
                _deadpool.MoveRight();



            //-------------------------------------------------------------------------------------------
            _deadpool.DrawMe();

            if (Collision(_deadpool, _goal))
            {
                Graphics.ShowResult(true);
            }
            else
            {
                Graphics.ShowResult(false);
            }

            // Call the Teleport method to get a random x and y
            //  use the random x and y variables to update the X and Y properties of the _deadpool object

            _deadpool.DrawMe();
        }

        //-------------------------------------------------------------------------------------------
        //
        // PART 2: Passing Parameters
        //
        //  Write a method called Collision.
        //      Parameters: 2 game objects
        //      The method should check the position (X,Y) of object 1 to the position (X,Y) of object 2 
        //      Return true if they match otherwise return false.
        //
        //  Call Collision in place of the conditions in this line: if (_deadpool.X == _goal.X && _deadpool.Y == _goal.Y)
        //-------------------------------------------------------------------------------------------
        static bool Collision(GameObject obj1, GameObject obj2)
        {
            //bool isCollision = false;
            //if (obj1.X == obj2.X && obj1.Y == obj2.Y)
            //{
            //    return true;//isCollision = true;
            //}
            //return false;
            return obj1.X == obj2.X && obj1.Y == obj2.Y;
        }

        //-------------------------------------------------------------------------------------------
        //
        // PART 3 - Ref parameters
        //      Create a method called Colors.
        //          Parameters: 2 ConsoleColor variables. one for the foreground and one for the background
        //          The method should set them to whatever colors you want.
        //
        // Call the Colors method before the PART 1 code. Use the colors to update the Fore and Back colors of the _deadpool object
        //-------------------------------------------------------------------------------------------


        //-------------------------------------------------------------------------------------------
        //
        // PART 4 - Out parameters
        //      Create a method called Teleport.
        //          Parameters: 2 out parameters. one for the int x position and one for the int y position
        //          Randomly set them to valid x & y positions in the window.
        //              HINT: use Console.WindowWidth as the upper range for X and Console.WindowHeight as the upper range for Y
        //
        // At the end of the LectureChallenges method, call the Teleport method to get a random x and y.
        // Use the random x and y variables to update the X and Y properties of the _deadpool object.
        //-------------------------------------------------------------------------------------------



        #region Symbols
        static char deadPoolChar = '\u0308';
        static char dotChar = '\u2219';
        static char bigdotChar = '\u263C';// '\u25CF';// '\u25A0';
        #endregion

        #region Objects
        static GameObject _deadpool;
        static GameObject _goal;
        static GameObject[] _dots;

        private static void InitObjects()
        {
            _deadpool = new GameObject() { X = Console.WindowWidth / 2, Y = Console.WindowHeight / 2, Symbol = deadPoolChar, Back = ConsoleColor.Red, Fore = ConsoleColor.White };
            _goal = new GameObject() { X = _deadpool.X + 6, Y = _deadpool.Y, Symbol = bigdotChar, Back = ConsoleColor.Black, Fore = ConsoleColor.Yellow };
            _dots = new GameObject[7];
            for (int i = 0; i < _dots.Length; i++)
            {
                _dots[i] = new GameObject() { X = _deadpool.X + i, Y = _deadpool.Y, Fore = ConsoleColor.White, Symbol = dotChar };
            }
        }
        private static void DrawObjects()
        {
            foreach (var gameObject in _dots)
            {
                gameObject.DrawMe();
            }
            _goal.DrawMe();
            _deadpool.DrawMe();
        }
        #endregion



    }

    public static class Graphics
    {
        public static void DrawBlock()
        {
            int x = Console.WindowWidth / 2;
            int y = Console.WindowHeight / 2;

            Console.SetCursorPosition(x, y);
            Console.BackgroundColor = ConsoleColor.DarkCyan;

            Console.Write("     ");

            Console.ResetColor();
        }
        public static void ShowResult(bool result)
        {
            Console.SetCursorPosition(0, 7);
            if (result)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("RESULT: Success!!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("RESULT: Not quite. Try again.");
            }
            Console.ResetColor();
        }
    }
}
