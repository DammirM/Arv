using System;
using System.Collections.Generic;
using System.Text;

namespace Arv
{
    class Djur
    {

        // properties for every class that inherit from Djur class.
        public string Eat;
        public int Sleep;
        public int Run;
        public string Gender;
        public int Weight;

        public Djur():this("Kebab", 99,99,"Female",99)
        {
            // Default value for the properties
        }

        public Djur(string eat, int sleep, int run, string gender, int weight)
        {
            Eat = eat;
            Sleep = sleep;
            Run = run;
            Gender = gender;
            Weight = weight;
        }

        // 3 methods that all inherit classes can use but not change.
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

        // virtual method that we can change the content in the method and use the same method name
        public virtual void makeSound()
        {
            Console.WriteLine("Animal Sound");
        }
        
    }
}
