using System;
using System.Collections.Generic;
using System.Text;

namespace Arv
{
    class BabyTiger : Tiger
    {
        public string Walk;

        public BabyTiger():this("slow")
        {

        }

        public BabyTiger(string walk)
        {
            Walk = walk;
        }

        public BabyTiger(string walk,string jump, string eat, int sleep, int run, string gender, int weight)
        {
            Walk = walk;
            Jump = jump;
            Eat = eat;
            Sleep = sleep;
            Run = run;
            Gender = gender;
            Weight = weight;
        }

        public void Walking()
        {
            Console.WriteLine("BabyTiger likes to walk " + Walk);
        }

        public override void Jumping()
        {
            Console.WriteLine("The tigerbaby can jump up to the " + Jump);
        }

        public override void makeSound()
        {
            Console.WriteLine("Mjau rrrooooooaaaarrrrrrr");
        }
    }
}
