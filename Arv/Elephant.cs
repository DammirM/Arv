using System;
using System.Collections.Generic;
using System.Text;

namespace Arv
{
    class Elephant : Djur 
    {
        // Elephants property
        public int Year;

        public Elephant():this(48)
        {
            // Defalt of the Elephant property
        }

        public Elephant(int year)
        {
            Year = year;
        }

        // Contructor to create the Elphant animal
        public Elephant(int year,string eat, int sleep, int run, string gender, int weight)
        {
            Year = year;
            Eat = eat;
            Sleep = sleep;
            Run = run;
            Gender = gender;
            Weight = weight;
        }

        // Elephant own method
        public void aAge()
        {
            Console.WriteLine("The Elephant lifespan is {0} years", Year);
        }

        // Override method
        public override void makeSound()
        {
            Console.WriteLine("Barraaaaaaaag");
        }

    }
}
