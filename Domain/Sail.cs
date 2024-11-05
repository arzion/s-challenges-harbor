namespace Harbor.Domain;

public class Sail(bool isHighPerformance)
{
    public bool IsHighPerformance { get; private set; } = isHighPerformance;
}