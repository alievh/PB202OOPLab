namespace Zoo.Models;

internal class Elephant : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Elephant eating grass...");
    }

    public override void MakeSound()
    {
        Console.WriteLine("Elephant make noise!");
    }
}
