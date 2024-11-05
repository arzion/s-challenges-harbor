namespace Harbor.Domain;

public class Skipper(Boat boat)
{
    public string AskPropulsionType() => $"My boat is driven with {boat.PropulsionType}";
}