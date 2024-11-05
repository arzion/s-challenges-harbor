using AutoFixture.Xunit2;
using FluentAssertions;
using Moq;
using Xunit;

namespace Harbor.Domain.Tests.given_Skipper;

public class when_AskingForPropulsionType
{
    [Theory, ModelCustomization]
    public void then_AnswerIsExpected_if_SkipperOnPaddleBoat(
        [Frozen]Mock<Boat> boatMock,
        string boatPropulsionType,
        Skipper sut)
    {
        boatMock.Setup(b => b.PropulsionType).Returns(boatPropulsionType);

        var skipperAnswer = sut.AskPropulsionType();

        skipperAnswer.Should().Be($"My boat is driven with {boatPropulsionType}");
    }
}