using AnimalRescueCenter.Enums;
using System;


namespace AnimalRescueCenter.Models;

    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Diets Diet { get; set; }

    //MakeSound() kan vara här och efter classerna kan överrida det
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal sounds");
    }
}

