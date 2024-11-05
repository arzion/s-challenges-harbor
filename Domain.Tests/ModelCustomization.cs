using AutoFixture;
using AutoFixture.AutoMoq;
using AutoFixture.Xunit2;

namespace Harbor.Domain.Tests;

internal class ModelCustomization() : CompositeCustomization(new AutoMoqCustomization());

internal class ModelCustomizationAttribute() : AutoDataAttribute(() =>  new Fixture().Customize(new ModelCustomization()));

internal class InlineModelCustomizationAttribute(params object[]? values)
    : InlineAutoDataAttribute(new ModelCustomizationAttribute(), values);
