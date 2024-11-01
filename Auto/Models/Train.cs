using Auto.Interfaces;

namespace Auto.Models;

internal class Train : Vehicle, ISound
{
    private int _carriageCount;

    public Train(string brand, string model, int carriageCount) : base(brand, model)
    {
        CarriageCount = carriageCount;
    }

    public int CarriageCount
    {
        get => _carriageCount; set
        {
            if (value < 1)
            {
                Console.WriteLine("Carriage count can not be less than 1!");
            }
            else
            {
                _carriageCount = value;
            }
        }
    }

    public override void Drive()
    {
        Console.WriteLine("Train started...");
    }

    public void MakeSound()
    {
        Console.WriteLine("Tuf-tuf!");
    }
}
