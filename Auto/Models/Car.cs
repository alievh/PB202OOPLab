using Auto.Interfaces;

namespace Auto.Models;

internal class Car : Vehicle, ISound
{
    public string FuelType { get; set; }

    public Car(string brand, string model, string fuelType) : base(brand, model)
    {
        FuelType = fuelType;
    }

    public override void Drive()
    {
        Console.WriteLine("Car started...");
    }

    public void MakeSound()
    {
        Console.WriteLine("Bip-bip!");
    }
}
