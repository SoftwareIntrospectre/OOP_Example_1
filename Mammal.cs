using System;

namespace OOP_Example_1
{
    public class Mammal : Animal
    {
        public Mammal()
        {
            this.HasMammories = true;
        }

        public override void FeedYoung()
        {
                Console.WriteLine(Name + " feeds their young with breast milk.");
        }
    }
}