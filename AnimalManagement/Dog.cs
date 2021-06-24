using System;

namespace AnimalManagement
{
    public class Dog: Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Woof Woof!");
        }
    }
}