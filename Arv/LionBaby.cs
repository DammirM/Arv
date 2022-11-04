using System;
using System.Collections.Generic;
using System.Text;

namespace Arv
{
    class LionBaby : Tiger
    {
        public string Hair;

        public LionBaby() : this("Long hair")
        {

        }

        public LionBaby(string hair)
        {
            Hair = hair;
        }

        public LionBaby(string hair, string jump, string eat, int sleep, int run, string gender, int weight)
        {
            Hair = hair;
            Jump = jump;
            Eat = eat;
            Sleep = sleep;
            Run = run;
            Gender = gender;
            Weight = weight;
        }


        public void aHair()
        {
            Console.WriteLine("Lionbaby has {0} ", Hair);
        }
        public override void Jumping()
        {
            Console.WriteLine("The lionbaby can jump up to the " + Jump);
        }

        public override void makeSound()
        {
            Console.WriteLine("Lion rrrooooooaaaarrrrrrr");
        }
    }
}
