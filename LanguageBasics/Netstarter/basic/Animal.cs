class Animal
{
    internal string Species;
    internal int Weight;
    internal string Color;
    internal int Speed;
    internal bool IsPackAnimal;

      internal  Animal()
    {
        Color = "white"; // Provide a default color
        Species = "Artic Wolf";
    }

    internal void DisplayCharacteristics()
    {
        Console.Write($"This wolf belongs to species {Species}.");
        Console.Write($"Its weight is {Weight} kg.");
        Console.Write($"It has color {Color}.");
        Console.Write($"Its running speed is {Speed} km/h.");
        Console.Write($"It pack animal (true/false). The answer is {IsPackAnimal}.");
    }
       
    
}

