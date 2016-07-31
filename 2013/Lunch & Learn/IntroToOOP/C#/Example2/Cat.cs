using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntroToOOP.Example2
{
    public class Cat
    {            
        /* Constructor */
        public Cat()
        {
            /* State */
            this.Name = "Sue";
            this.Color = "Black";
        }

        /* Consctructor with parameters (different signature) */
        public Cat(string name, string color)
        {
            Name = name;
            Color = color;
        }        

        /* Public properties to allow the return and modification of the private members
         * Allow the State to be changed from outside the class*/
        public string Name { get; set;}
               
        public string Color { get; set;}           

        public void wagsTail()
        {
            Console.WriteLine("{0} wags tail...", Name);
        }

        public virtual void Speaks()
        {
            Console.WriteLine("{0} purrs...", Name);
        }

    }

    public class OohCat : Cat
    {         
        public override void Speaks()
        {
            Console.WriteLine("{0} raises hand to mouth slowly and says OOOOOHHH", Name);
        }
    }
}
