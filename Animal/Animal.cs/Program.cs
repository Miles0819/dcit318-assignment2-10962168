// See https://aka.ms/new-console-template for more information
// Animal.cs
public abstract class Animal
{
    public abstract void MakeSound();
}

// Dog.cs
public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

// Cat.cs
public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

// Cow.cs
public class Cow : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Moo");
    }
}

// Program.cs
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the name of the animal you want to hear the sound of:");
        string animalName = Console.ReadLine();

        Animal animal;
        switch (animalName.ToLower())
        {
            case "dog":
                animal = new Dog();
                break;
            case "cat":
                animal = new Cat();
                break;
            case "cow":
                animal = new Cow();
                break;
            default:
                Console.WriteLine("Sorry, I don't have information about the sound that animal makes.");
                return;
        }

        animal.MakeSound();
    }
}
