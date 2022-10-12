using AnimalRescueCenter.Enums;
using AnimalRescueCenter.Models;

namespace AnimalRescueCenter;

    public class AnimalManager
    {
        private List<Animal> allAnimals = new();

    //Seed- betyder att ladda data ner programen startar
    public void SeedData() 
    {
        //Skapa några olika djur
        // Lägg till dom i listan

        Dog dog = new();
        dog.Name = "Rufus";
        dog.Age = 10;
        dog.Diet = Diets.Carnivore;  // Enums.Diets.Carnivore;
        allAnimals.Add(dog);

        Animal cat = new Cat();
        cat.Name = "Zimba";
        cat.Age = 12;
        cat.Diet = Diets.Omnivore;
        allAnimals.Add(cat);

        Bird bird = new()
        {
            Name = "Sixten",
            Age = 3,
            Diet = Diets.Carnivore
        };
        allAnimals.Add(bird);

        allAnimals.Add(new Reptil()
            {
                Name = "Terminator",
                Age= 50,
                Diet = Diets.Herbivore
        
            }); 

    }

    public void PrintAllAnimals()
    {
     foreach(Animal animal in allAnimals)
        {
            Console.WriteLine(animal.Name);
        }   
    }
}

