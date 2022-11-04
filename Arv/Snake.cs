using System;
using System.Collections.Generic;
using System.Text;

namespace Arv
{
    class Snake : Djur
    {
        // Same as Elephant

        public string Poison;

        public Snake() : this("Poison")
        {

        }
        public Snake(string poison)
        {
            Poison = poison;
        }
        public Snake(string poison, string eat, int sleep, int run, string gender, int weight)
        {
            Poison = poison;
            Eat = eat;
            Sleep = sleep;
            Run = run;
            Gender = gender;
            Weight = weight;
        }


        public void Pois()
        {
            Console.WriteLine("A snakes bite can be " + Poison);
        }
        public override void makeSound()
        {
            Console.WriteLine("Tsssssssssssssss");
        }
    }
}
