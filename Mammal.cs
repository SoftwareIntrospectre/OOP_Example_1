using System;

namespace OOP_Example_1
{
    public class Mammal : Animal
    {
        public Mammal()
        {
            this.HasMammories = true;
            this.Name = Name;
        }
        public override void Eat()
        {
            if(IsCarnivore)
                Console.WriteLine(Name + " eats meat");

            else
                Console.WriteLine(Name + " does not eat meat");
        }

        public override void Sleep()
        {
            if(IsNocturnal)
                Console.WriteLine(Name + " sleeps during the day");

            else
                Console.WriteLine(Name + " does not sleep during the day.");
        }

        public override void FeedYoung()
        {
                Console.WriteLine(Name + " feeds their young with breast milk.");
        }
    }
}