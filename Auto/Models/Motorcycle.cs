using Auto.Interfaces;

namespace Auto.Models
{
    internal class Motorcycle : Vehicle, ISound
    {
        public string RaceType { get; set; }

        public Motorcycle(string brand, string model, string raceType) : base(brand, model)
        {
            RaceType = raceType;
        }

        public override void Drive()
        {
            Console.WriteLine("Motorcycle started...");
        }

        public void MakeSound()
        {
            Console.WriteLine("Vin-vin!");
        }
    }
}
