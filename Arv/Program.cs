using System;

namespace Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Elephant: ");
            Elephant elefant = new Elephant();
            elefant.makeSound();

            Console.Write("\nSnake: ");
            Snake orm = new Snake();
            orm.makeSound();

            Console.Write("\nTiger: ");
            Tiger tiger = new Tiger();
            tiger.makeSound();

            Console.Write("\nBabyTiger: ");
            BabyTiger baby = new BabyTiger();
            baby.makeSound();

            Console.Write("\nLionBaby: ");
            LionBaby lejon = new LionBaby();
            lejon.makeSound();





            Console.ReadKey();
        }
    }
}
