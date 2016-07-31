using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntroToOOP.Example1
{
    public class Cat
    {
         /*Internal Members*/
        private string _name;
        private string _color; 

        /* Constructor */
        public Cat()
        {
            /* State */
            _name = "Hip Cat";
            _color = "Orange";
        }

        /* Consctructor with parameters (different signature) */
        public Cat(string name, string color)
        {
            _name = name;
            _color = color;
        }

        /* Public properties to allow the return and modification of the private members
         * Allow the State to be changed from outside the class*/

        /* State */
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        /* read-only */
        public string Color
        {
            get
            {
                return _color;
            }          
        }

        /* Behavior */
        public void wagsTail()
        {
            Console.WriteLine("{0} wags tail...", _name);
        }

        public void Speaks()
        {
            Console.WriteLine("{0} purrs...", _name);
        }

    }
}
