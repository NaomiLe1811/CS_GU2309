using System;
namespace HW_12_OOP_Animal_Interface
{
    public class Chicken:Animal, Edible
    {
        public override string MakeSound()
        {
            return "Chicken: cluck-cluck!";
        }

        public string HowToEat()
        {
            return "could be fried";
        }
    }
}
