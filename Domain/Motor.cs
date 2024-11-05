namespace Harbor.Domain;

public class Motor(bool isHighPerformance)
{
    public bool IsHighPerformance { get; private set; } = isHighPerformance;
}