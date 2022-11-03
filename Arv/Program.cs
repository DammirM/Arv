using System;

namespace Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elephant:");
            Elephant E = new Elephant();
            E.makeSound();

            Console.WriteLine("\nSnake:");
            Snake S = new Snake();
            S.makeSound();

            Console.WriteLine("\nTiger:");
            Tiger T = new Tiger();
            T.makeSound();

            Console.WriteLine("\nBabyTiger:");
            BabyTiger B = new BabyTiger();
            B.makeSound();

            Console.WriteLine("\nLionBaby:");
            LionBaby L = new LionBaby();
            L.makeSound();












        }
    }
}
