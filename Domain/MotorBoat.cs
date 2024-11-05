namespace Harbor.Domain;

public class MotorBoat(string name, Motor motor) : Boat(name)
{
    public override string MakeSound() => motor.IsHighPerformance ? "wroooooooooom" : "wrooom";

    public override string PropulsionType => motor.IsHighPerformance ? "special fuel" : "oil";
}