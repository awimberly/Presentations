using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IntroToOOP.Example3;

namespace IntroToOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cat hipCat = new Cat();
            //hipCat.wagsTail();
            //hipCat.Speaks();
            
            #region Example1
            //Cat HeathCliff = new Cat("Heathcliff", "orange");
            //HeathCliff.wagsTail();
            //HeathCliff.Speaks();
            #endregion

            #region Example2
            //OohCat Ooh = new OohCat();
            //Ooh.Name = "OohCat";
            //Ooh.wagsTail();
            //Ooh.Speaks();
            #endregion

            #region Example3
            Program p = new Program();

            Cat sueCat = new Cat();
            Cat HeathCliff = new Cat();
            OohCat Ooh = new OohCat();
            Dog myDog = new Dog();
            
            p.doAnimalStuff(sueCat, "Sue");
            p.doAnimalStuff(HeathCliff, "Heathcliff");
            p.doAnimalStuff(Ooh, "OohCat");
            p.doAnimalStuff(myDog, "Brain");
            #endregion            

            Console.ReadLine();// Pause
        }

        #region Example3
        public void doAnimalStuff(Animal myAnimal, string name)
        {
            myAnimal.Name = name;
            myAnimal.wagsTail();
            myAnimal.Speaks();
        }
        #endregion
               
    }
}
