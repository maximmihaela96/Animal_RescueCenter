// Scenario: Se alla djur
// Loopa igenom alla djur och printa lite data
// Fråga vad användaren vill göra härnäst

// Scenario: Lägga till djur
// Fråga användaren om namn, ålder o.s.v
// Lägg till djuret i listan med alla djur
// Visa alla djur

// Scenario: Ta bort djur
//  Visa alla djur
//  Fråga användaren om namnet på djuret den vill ta bort från listan
//  Om ett namn matchar, ta bort det djuret
//  Om inte, fråga igen!
//  Visa alla djur

// Scenario: Uppdatera djur
// Vissa alla djur
// Fråga användaren om namnet på djuret den vill uppdatera
// Om ett namn matchar, då vidare
// Om inte, fråga igen
// Fråga användaren om vad den vill uppdatera med djuret
// Be användaren skriva in det nya värde
// Visa alla djur

using AnimalRescueCenter;

AnimalManager animalManager = new();
animalManager.SeedData();
animalManager.PrintAllAnimals();

Console.WriteLine("************");
//Saknar objecter animalManager.SeedData();
AnimalManager animalMeneger2 = new();
animalMeneger2.PrintAllAnimals();