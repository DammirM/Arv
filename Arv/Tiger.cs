using System;
using System.Collections.Generic;
using System.Text;

namespace Arv
{
    class Tiger : Djur
    {
        // Same as Elephant

        public string Jump;

        public Tiger():this("Sky")
        {

        }
        public Tiger(string jump)
        {
            Jump = jump;
        }
        public Tiger(string jump, string eat, int sleep, int run, string gender, int weight)
        {
            Jump = jump;
            Eat = eat;
            Sleep = sleep;
            Run = run;
            Gender = gender;
            Weight = weight;
        }

        // Share the method with the classes that will inherit.
        public virtual void Jumping()
        {
            Console.WriteLine("The tiger can jump up to the " + Jump);
        }


        public override void makeSound()
        {
            Console.WriteLine("Roooooooaarrrrrrr");
        }

    }
}
