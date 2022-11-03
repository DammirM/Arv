using System;
using System.Collections.Generic;
using System.Text;

namespace Arv
{
    class Elephant : Djur 
    {



        public int Year;

        public Elephant():this(48)
        {


        }

        public Elephant(int year)
        {
            Year = year;
            
        }

        public Elephant(int year,string eat, int sleep, int run, string gender, int weight)
        {

            Year = year;
            Eat = eat;
            Sleep = sleep;
            Run = run;
            Gender = gender;
            Weight = weight;
        }





        public void aAge()
        {

            Console.WriteLine("The Elephant lifespan is {0} years", Year);
        }

        public override void makeSound()
        {
            Console.WriteLine("Barraaaaaaaag");

        }
    }
}
