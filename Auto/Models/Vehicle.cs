namespace Auto.Models
{
    internal abstract class Vehicle
    {
        private int _maxSpeed;

        public string Brand { get; }
        public string Model { get; }

        public Vehicle(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        public int MaxSpeed
        {
            get => _maxSpeed;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Speed can not be less than zero!");
                }
                else
                {
                    _maxSpeed = value;
                }
            }
        }


        public virtual void Drive()
        {
            Console.WriteLine("Vehicle started...");
        }
    }
}
