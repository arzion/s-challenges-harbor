using AutoFixture.Xunit2;
using FluentAssertions;
using Xunit;

namespace Harbor.Domain.Tests.given_PaddleBoat;

public class when_GettingPropulsionType
{
    [Theory, InlineAutoData]
    public void then_PropulsionIsExpected(
        string anyName,
        Paddles anyPaddles)
    {
        var boat = new PaddleBoat(anyName, anyPaddles);

        var actualPropulsionType = boat.PropulsionType;

        actualPropulsionType.Should().Be("hands");
    }
}