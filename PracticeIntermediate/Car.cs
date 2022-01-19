using System;

namespace PracticeIntermediate
{
    public class Car:Vehicle
    {
        public Car(string reg)
            :base(reg)
        {
            Console.WriteLine("Car constructor");
        }
    }
}
