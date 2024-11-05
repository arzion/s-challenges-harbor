namespace Harbor.Domain;

public abstract class Boat(string name)
{
    public string Name { get; } = name;

    public abstract string MakeSound();

    public abstract string PropulsionType { get; }
}