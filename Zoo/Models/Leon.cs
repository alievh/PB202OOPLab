namespace Zoo.Models;

internal class Leon : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Leon eating meat...");
    }

    public override void MakeSound()
    {
        Console.WriteLine("Leon make noise!");
    }
}
