﻿using AutoFixture;
using Domain.Entities;
namespace Domain.Tests.Entities;

[Trait("Task", "Unit Tests")]
public class ItemTest
{
    private readonly Fixture _fixture;

    public ItemTest()
    {
        _fixture = new Fixture();
    }

    [Fact(DisplayName = "When mandatory parameters are missing task must return not valid")]
    public void WhenMandatoryParametersAreMissingTaskMustReturnNotValid()
    {
        var item = _fixture.Build<Item>().FromFactory(() => new Item("", "", null)).Create();
        Assert.False(item.IsValid());
    }

    [Fact(DisplayName = "When mandatory parameters are ok task must return valid")]
    public void WhenMandatoryParametersAreOkTaskMustReturnValid()
    {
        var item = _fixture.Build<Item>().FromFactory(() => new Item("test", "teste", null)).Create();
        Assert.True(item.IsValid());
    }
}
