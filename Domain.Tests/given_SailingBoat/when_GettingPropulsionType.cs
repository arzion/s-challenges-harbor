using AutoFixture.Xunit2;
using FluentAssertions;
using Xunit;

namespace Harbor.Domain.Tests.given_sailingBoat;

public class when_GettingPropulsionType
{
    [Theory, InlineAutoData]
    public void then_PropulsionTypeIsWind(string anyName, Sail anySail)
    {
        var boat = new SailingBoat(anyName, anySail);

        var actualPropulsionType = boat.PropulsionType;

        actualPropulsionType.Should().Be("wind");
    }
}