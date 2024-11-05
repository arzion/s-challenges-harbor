using AutoFixture.Xunit2;
using FluentAssertions;
using Xunit;

namespace Harbor.Domain.Tests.given_PaddleBoat;

public class when_MakingSound
{
    [Theory, InlineAutoData]
    public void then_SoundIsExpected(
        string anyName,
        Paddles anyPaddles)
    {
        var boat = new PaddleBoat(anyName, anyPaddles);

        var actualSound = boat.MakeSound();

        actualSound.Should().Be("splash");
    }
}