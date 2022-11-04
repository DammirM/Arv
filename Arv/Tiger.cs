using System;
using System.Collections.Generic;
using System.Text;

namespace Arv
{
    class Tiger : Djur
    {

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
