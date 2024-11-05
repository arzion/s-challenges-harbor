namespace Harbor.Domain;

public class PaddleBoat(string name, Paddles paddles) : Boat(name)
{
    public Paddles Paddles { get; } = paddles;

    public override string MakeSound() => "splash";

    public override string PropulsionType => "hands";
}