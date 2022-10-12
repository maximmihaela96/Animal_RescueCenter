using AnimalRescueCenter.Enums;
using AnimalRescueCenter.Models;

namespace AnimalRescueCenter;

    public class AnimalManager
    {
        private List<Animal> allAnimals = new();
    // Kan ha en konstructor med SeedData() in

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

    private void PrintAllAnimals()
    {
     foreach(Animal animal in allAnimals)
        {
            Console.WriteLine(animal.Name);
        }   
    }

    public void  DetermineAction() 
    {
        Console.Clear();
        PrintHeader();
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("(s)ee alla | (a)dd | (d)elete | (u)pdate");
        Console.WriteLine("Reply:");
        string respons = Console.ReadLine();

        switch (respons.ToLower())
        {
            case "s":
                {
                    Console.WriteLine();
                    PrintAllAnimals();
                    AskToContinue();
                    DetermineAction();
                    //Visa alla djur
                    break;
                }
            case "a":
                {
                    //Lägga till  djur
                    AddAnimal();
                    PrintAllAnimals();
                    AskToContinue();
                    DetermineAction();
                   
                    break;
                }
            case "d":
                {
                    //Ta bort  djur
                    PrintAllAnimals();
                    //GetAnimalByName();
                    Animal animalToDelete = GetAnimalByName();
                    RemoveAnimal(animalToDelete);
                    AskToContinue();
                    DetermineAction();
                  
                    break;
                }
            case "u":
                {
                    //Uppdatera  djur
                    break;
                }
            default:
                {
                    Console.WriteLine("Användaren har skrivit någon annat");
                    break;
                }
        }
    }

    private void RemoveAnimal(Animal animalToDelete)
    {
        allAnimals.Remove(animalToDelete);
    }

    private Animal GetAnimalByName()
    {
        Console.WriteLine();
        Console.WriteLine("What is the name of the animal");
        Console.Write("Name:");
        string respons = Console.ReadLine();

        for(int i = 0; i < allAnimals.Count; i++)
        {
            //
            Animal animal = allAnimals[i];
            //Om dem tva er samma
            if(animal.Name.ToLower() == respons.ToLower().Trim())
            {
                return animal;
            }

        }
        //null
        return null;
    }

    private void AddAnimal()
    {
        Console.WriteLine();
        Console.WriteLine("What is the name of the animal you want to add?");
        Console.Write("Name:");
        string animalName = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Great! What is the age of the animal ?");
        Console.Write("Age:");
        string animalAge = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Great! Is the animal a  (1)herbivore, (2)omnivore or (3)carnivore?");
        Console.Write("Diet:");
        string animalDietIndex = Console.ReadLine();


        Console.WriteLine();
        Console.WriteLine("Is the animal a dog, cat, bird or reptile?");
        Console.Write("Type:");
        string animalType = Console.ReadLine();

        switch (animalType.ToLower())
        {
            case "dog":
                {
                    //att ett generisk metod som ska skaffa det gellande vad anvendaren skriver
                    //Skapa en hund
                    Dog dog = new();
                    dog.Name = animalName;
                    dog.Age = Convert.ToInt32(animalAge);
                    //Omvandla
                    dog.Diet = (Diets)int.Parse(animalDietIndex);//Enum.GetNames(typeof(Diets), Convert.ToInt32(animalDiet)); //(Diets)Enum.Parse(typeof(Diets), animalDiet);

                    allAnimals.Add(dog);

                    break;
                }

            case "cat":
                {
                    //Skapa en cat
                    Cat cat = new();
                    cat.Name = animalName;
                    cat.Age = Convert.ToInt32(animalAge);
                    cat.Diet = (Diets)Enum.Parse(typeof(Diets), animalDietIndex);

                    allAnimals.Add(cat);
                    break;
                }

            case "bird":
                {
                    //Skapa en bord
                    Bird bird = new();
                    bird.Name = animalName;
                    bird.Age = Convert.ToInt32(animalAge);
                    bird.Diet = (Diets)Enum.Parse(typeof(Diets), animalDietIndex);

                    allAnimals.Add(bird);
                    
                    break;
                }

            case "reptile":
                {
                    //Skapa en reptile
                    Reptil reptil = new();
                    reptil.Name = animalName;
                    reptil.Age = Convert.ToInt32(animalAge);
                    reptil.Diet = (Diets)Enum.Parse(typeof(Diets), animalDietIndex);

                    allAnimals.Add(reptil);
                    break;
                }
        }    
    }

    private void AskToContinue()
    {
        Console.WriteLine();
        Console.WriteLine("Press enter to continue");
        Console.ReadLine();
    }

    private void PrintHeader() 
    {
        Console.WriteLine("¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤");
        Console.WriteLine("Welcome to the Animal Resque Center!");
        Console.WriteLine("¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤");
    }

}


