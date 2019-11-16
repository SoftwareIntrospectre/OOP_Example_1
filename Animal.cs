using System;

namespace OOP_Example_1
{
    public abstract class Animal
    {
        private string _name;

        private bool _hasMammories;

        private bool _isCarnivore;

        private bool _isNocturnal;

        public virtual string Name {get{return _name;} set{_name = value;}}

        public virtual bool HasMammories {get{return _hasMammories;} set{_hasMammories = value;}}

        public virtual bool IsCarnivore {get{return _isCarnivore;} set{_isCarnivore = value;}}

        public virtual bool IsNocturnal {get{return _isNocturnal;} set{_isNocturnal = value;}}

        public void Eat()
        {
            if(IsCarnivore)
                Console.WriteLine(Name + " eats meat");

            else
                Console.WriteLine(Name + " does not eat meat");
        }

        public void Sleep()
        {
            if(IsNocturnal)
                Console.WriteLine(Name + " sleeps during the day");

            else
                Console.WriteLine(Name + " does not sleep during the day.");
        }


        public virtual void FeedYoung()
        {

        }
    }
}