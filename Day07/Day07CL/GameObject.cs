using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class GameObject
    {
        //ACCESS MODIFIERS
        //public: EVERYONE can see it
        //private: ONLY this class can see it  (default)
        //protected: this class and all my descendent classes can see it

        #region Fields
        // _camelCasingNamingConvention
        //  compound word: first word starts with lowercase, all others start with uppercase
        //  _  helps set it aside from local variables and parameters
        private int _x = 0, _y = 0;
        #endregion

        #region Properties
        // FULL property: has a backing field.
        // if you write any code in the get/set, you need a full property
        public int X
        {
            //same as...
            //public int GetX() {return _x;}
            get { return _x; }

            //same as...
            //public void SetX(int value) {_x = value;}
            set { 
                if(value >=0 && value < Console.WindowWidth)
                    _x = value; 
            }//value is a keyword
        }
        public int Y
        {
            //same as...
            //public int GetY() {return _y;}
            get { return _y; }

            //same as...
            //public void SetY(int value) {_y = value;}
            set
            {
                if (value >= 0 && value < Console.WindowHeight)
                    _y = value;
            }//value is a keyword
        }

        // an AUTO property: the compiler provides the field and the code for get/set
        public ConsoleColor Color { get; private set; } = ConsoleColor.DarkCyan;
        #endregion

        #region Constructors (ctor)
        //compiler will provide a DEFAULT constructor (no params and no code)
        //

        //as soon as we provide our own constructor, the compiler
        //version is no longer available
        //public GameObject()//default constructor (no params)
        //{
        //}

        public GameObject(int x, int y, ConsoleColor color)
        {
            X = x;
            Y = y;
            Color = color;
        }


        #endregion
    }
}
