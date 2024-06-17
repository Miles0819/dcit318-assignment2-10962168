// See https://aka.ms/new-console-template for more information
using System;

public interface IMovable
{
    void Move();
}

public class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

public class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter 'car' or 'bicycle':");
        string input = Console.ReadLine().ToLower();

        IMovable movable = null;

        if (input == "car")
        {
            movable = new Car();
        }
        else if (input == "bicycle")
        {
            movable = new Bicycle();
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter 'car' or 'bicycle'.");
            return;
        }

        movable.Move();
    }
}