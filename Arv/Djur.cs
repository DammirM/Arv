using System;
using System.Collections.Generic;
using System.Text;

namespace Arv
{
    class Djur
    {
        public string Eat;
        public int Sleep;
        public int Run;
        public string Gender;
        public int Weight;



        public Djur():this("Kebab", 99,99,"Female",99)
        {
            
        }

        public Djur(string eat, int sleep, int run, string gender, int weight)
        {

            Eat = eat;
            Sleep = sleep;
            Run = run;
            Gender = gender;
            Weight = weight;
        }

        

        public void Eating()
        {
            Console.WriteLine("This animal likes to eat: " + Eat);

        }

        public void Running()
        {

            Console.WriteLine("This animal speed is {0} mph", Run);
        }

        public void aGender()
        {

            Console.WriteLine("This animal gender is: " + Gender);
        }

        public virtual void makeSound()
        {

            Console.WriteLine("Animal Sound");
        }

        public virtual void AnimalInfo()
        {

            Console.WriteLine("The animal likes");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
