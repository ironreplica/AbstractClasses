using System;

Main();
void Main()
{
    Animal[] animals = { new Dog(), new Cat(), new Horse() };
    foreach (Animal animal in animals)
    {
        animal.EatFood();
    }
}

public abstract class Animal
{
    public abstract void EatFood();
}
public class Dog : Animal
{
    public override void EatFood()
    {
        Console.WriteLine("Im a dog and im eating food.");
    }
}
public class Cat : Animal
{
    public override void EatFood()
    {
        Console.WriteLine("Im a Cat and im eating food.");
    }
}
public class Horse : Animal
{
    public override void EatFood()
    {
        Console.WriteLine("Im a Horse and im eating food.");
    }
}