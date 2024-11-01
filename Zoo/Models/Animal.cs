namespace Zoo.Models;

internal abstract class Animal
{
    private int _age;

    public string Name { get; set; }
    public int Age
    {
        get => _age; set
        {
            if (value > 0)
            {
                _age = value;
            }
            else
            {
                Console.WriteLine("Age can not be less than zero!");
            }
        }
    }

    public abstract void Eat();

    public abstract void MakeSound();

}
