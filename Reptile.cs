using System;

namespace OOP_Example_1
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            this.HasMammories = false;
        }

        public override void FeedYoung()
        {
                Console.WriteLine(Name + " does not feed their young with breast milk.");
        }
    }
}