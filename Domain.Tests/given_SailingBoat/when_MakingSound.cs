using AutoFixture.Xunit2;
using FluentAssertions;
using Xunit;

namespace Harbor.Domain.Tests.given_SailingBoat;

public class when_MakingSound
{
    [Theory]
    [InlineAutoData(true, "wooooooooosh")]
    [InlineAutoData(false, "wooosh")]
    public void then_SoundIsDependentOnInstalledSail(
        bool isHighPerformanceSail,
        string expectedSound,
        string anyName)
    {
        var sail = new Sail(isHighPerformanceSail);
        var boat = new SailingBoat(anyName, sail);

        var actualSound = boat.MakeSound();

        actualSound.Should().Be(expectedSound);
    }
}