using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToyRobotSimulator.Services;
using ToyRobotSimulator.Services.Helper;

namespace ToyRobotSimulator.UnitTests
{
    [TestClass]
    class TestPlacement
    {
        /// <summary>
        /// Test valid position and direction for a toy
        /// </summary>
        [TestMethod]
        public void TestValidPositionDirection()
        {
            // arrange
            var toyPosition = new ToyPosition(3, 3);
            var toyRobot = new ToyRobotPlacementService();

            // act
            toyRobot.PlaceToy(toyPosition, ToyFacingDirectionEnum.North);

            // assert
            Assert.AreEqual(3, toyRobot.Position.X_Coordinate);
            Assert.AreEqual(3, toyRobot.Position.Y_Coordinate);
            Assert.AreEqual(ToyFacingDirectionEnum.North, toyRobot.Direction);
        }

        /// <summary>
        /// Check if Move command works
        /// </summary>
        [TestMethod]
        public void TestValidToyMove()
        {
            // arrange
            var toyRobot = new ToyRobotPlacementService { Direction = ToyFacingDirectionEnum.East, Position = new ToyPosition(2, 2) };

            // act
            var nextPosition = toyRobot.GetNextAvailablePosition();

            // assert
            Assert.AreEqual(3, nextPosition.X_Coordinate);
            Assert.AreEqual(2, nextPosition.Y_Coordinate);
        }


        /// <summary>
        /// Test if Toy can rotate Right
        /// </summary>
        [TestMethod]
        public void TestValidToyRotateRight()
        {
            // arrange
            var toyRobot = new ToyRobotPlacementService { Direction = ToyFacingDirectionEnum.East, Position = new ToyPosition(3, 4) };

            // act
            toyRobot.Rotate(ToyCommandEnum.Right);

            // assert
            Assert.AreEqual(ToyFacingDirectionEnum.North, toyRobot.Direction);
        }

        /// <summary>
        /// Test if Toy does not rotate right when edge consition is reached
        /// </summary>
        [TestMethod]
        public void TestInValidToyRotateRight()
        {
            // arrange
            var toyRobot = new ToyRobotPlacementService { Direction = ToyFacingDirectionEnum.North, Position = new ToyPosition(3, 4) };

            // act
            toyRobot.Rotate(ToyCommandEnum.Right);

            // assert
            Assert.AreEqual(ToyFacingDirectionEnum.South, toyRobot.Direction);
        }


        /// <summary>
        /// Test if Toy can rotate Left
        /// </summary>
        [TestMethod]
        public void TestValidToyRotateLeft()
        {
            // arrange
            var toyRobot = new ToyRobotPlacementService { Direction = ToyFacingDirectionEnum.West, Position = new ToyPosition(2, 1) };

            // act
            toyRobot.Rotate(ToyCommandEnum.Left);

            // assert
            Assert.AreEqual(ToyFacingDirectionEnum.North, toyRobot.Direction);
        }

        /// <summary>
        /// Test if Toy can rotate Left
        /// </summary>
        [TestMethod]
        public void TestInValidToyRotateLeft()
        {
            // arrange
            var toyRobot = new ToyRobotPlacementService { Direction = ToyFacingDirectionEnum.West, Position = new ToyPosition(2, 1) };

            // act
            toyRobot.Rotate(ToyCommandEnum.Left);

            // assert
            Assert.AreEqual(ToyFacingDirectionEnum.South, toyRobot.Direction);
        }

        /// <summary>
        /// Check if Report command works
        /// </summary>
        [TestMethod]
        public void TestValidToyReport()
        {
            // arrange
            var robot = new ToyRobotPlacementService { Direction = ToyFacingDirectionEnum.East, Position = new ToyPosition(2, 2) };

            // act
            var nextPosition = robot.GetNextAvailablePosition();

            // assert
            Assert.AreEqual(3, nextPosition.X_Coordinate);
            Assert.AreEqual(2, nextPosition.Y_Coordinate);
        }


    
    }
}
