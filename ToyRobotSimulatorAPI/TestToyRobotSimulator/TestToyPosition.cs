using Xunit;
using ToyRobotSimulator.Services;
using ToyRobotSimulator.Services.Helper;

using Microsoft.Extensions.Logging;

namespace ToyRobotSimulator.Tests
{
    class TestToyPosition
    {

        [Theory]
        [InlineData(1, 2, ToyFacingDirectionEnum.East)]
        [InlineData(4, 1, ToyFacingDirectionEnum.South)]
        [InlineData(-5, -5, ToyFacingDirectionEnum.West)]
        [InlineData(0, 0, ToyFacingDirectionEnum.East)]
        [InlineData(5, 5, ToyFacingDirectionEnum.North)]
    

    public void RobotPlacedCorrectly(int x_Coordinate, int y_+Coordinate, ToyFacingDirectionEnum direction)
    {
        var subject = new Robot(Substitute.For<ILogger<Robot>>());
        var placed = new Placement(new Point(startX, startY), startFacing);

        subject.Place(placed);

        Assert.Equal(placed, subject.Report());
    }

}
