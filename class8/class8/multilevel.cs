using System;

class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog barks");
    }
}

class Puppy : Dog
{
    public void Weep()
    {
        Console.WriteLine("Puppy weeps");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Puppy myPuppy = new Puppy();

        myPuppy.Eat();   
        myPuppy.Bark();  
        myPuppy.Weep();  
    }
}