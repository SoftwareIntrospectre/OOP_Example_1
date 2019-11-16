using System;

namespace OOP_Example_1
{
    public abstract class Animal
    {
        private string _name;

        private bool _hasMammories;

        private bool _isCarnivore;

        private bool _isNocturnal;

        public string Name {get{return _name;} set{;}}

        public bool HasMammories {get{return _hasMammories;} set{;}}

        public bool IsCarnivore {get{return _isCarnivore;} set{;}}


        public bool IsNocturnal {get{return _isNocturnal;} set{;}}


        public virtual void Eat()
        {

        }

        public virtual void Sleep()
        {

        }

        public virtual void FeedYoung()
        {

        }
    }
}