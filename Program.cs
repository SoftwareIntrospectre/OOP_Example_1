using System;

namespace OOP_Example_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var sloth = new Mammal();
            sloth.Name = "Sloth Ross";
            Console.WriteLine("Sloth's name is: " + sloth.Name );
            sloth.IsCarnivore = false;
            sloth.IsNocturnal = true;
            sloth.Sleep();
            sloth.FeedYoung();
            sloth.Eat();

            var komodoDragon = new Reptile();
            komodoDragon.Name = "Karl Komodo";
            Console.WriteLine("Komodo Dragon's name is: " + komodoDragon.Name );

            komodoDragon.IsCarnivore = true;
            komodoDragon.IsNocturnal = false;
            komodoDragon.Sleep();
            komodoDragon.FeedYoung();
            komodoDragon.Eat();
         }
    }
}
