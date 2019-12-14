using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToyRobotSimulator.Services;
using ToyRobotSimulator.Services.Helper;

namespace ToyRobotSimulator.UnitTests
{
    [TestClass]
    public class TestBoardConstraints
    {

       
        /// <summary>
        /// Test to check if toy poistion is availabe when the coordinates are within the range of the board
        /// </summary>
        [TestMethod]
        public void TestBoardAvailabilityValid()
        {
            // arrange
            IToyBoardService toyBoardService = new ToyBoardService(5, 5);
            ToyPosition toyposition = new ToyPosition(0, 5);

            // act
            var result = toyBoardService.CheckPositionAvailability(toyposition);

            // assert
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test to check if toy poistion is availabe when the coordinates are outside the range of the board
        /// </summary>
        [TestMethod]

        public void TestBoardAvailabilityInValid()
        {
            // arrange
            IToyBoardService toyBoardService = new ToyBoardService(5, 5);
            ToyPosition toyposition = new ToyPosition(7, 8);

            // act
            var result = toyBoardService.CheckPositionAvailability(toyposition);

            // assert
            Assert.IsFalse(result);
        }
    }
}
