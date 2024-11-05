using AutoFixture.Xunit2;
using FluentAssertions;
using Xunit;

namespace Harbor.Domain.Tests.given_MotorBoat;

public class when_GettingPropulsionType
{
    [Theory]
    [InlineAutoData(true, "special fuel")]
    [InlineAutoData(false, "oil")]
    public void then_PropulsionTypeIsDependentOnInstalledMotor(
        bool isHighPerformanceMotor,
        string expectedPropulsionType,
        string anyName)
    {
        var motor = new Motor(isHighPerformanceMotor);
        var boat = new MotorBoat(anyName, motor);

        var actualPropulsionType = boat.PropulsionType;

        actualPropulsionType.Should().Be(expectedPropulsionType);
    }
}