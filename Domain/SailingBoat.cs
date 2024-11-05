namespace Harbor.Domain;

public class SailingBoat(string name, Sail sail) : Boat(name)
{
    public override string MakeSound() => sail.IsHighPerformance ? "wooooooooosh" : "wooosh";

    public override string PropulsionType => "wind";
}