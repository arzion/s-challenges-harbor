using AutoFixture.Xunit2;
using FluentAssertions;
using Xunit;

namespace Harbor.Domain.Tests.given_MotorBoat;

public class when_MakingSound
{
    [Theory]
    [InlineAutoData(true, "wroooooooooom")]
    [InlineAutoData(false, "wrooom")]
    public void then_SoundIsDependentOnInstalledMotor(
        bool isHighPerformanceMotor,
        string expectedSound,
        string anyName)
    {
        var motor = new Motor(isHighPerformanceMotor);
        var boat = new MotorBoat(anyName, motor);

        var actualSound = boat.MakeSound();

        actualSound.Should().Be(expectedSound);
    }
}