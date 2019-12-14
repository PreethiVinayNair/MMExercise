using System;
using System.Collections.Generic;
using System.Text;
using NUnit;
namespace ToyRobotSimulator.Tests
{
 
    public class TestConstraints
    {
        /// <summary>
        /// Try to put the toy outside of the board
        /// </summary>
        [Test]
        public void TestInvalidBoardPosition()
        {
            // arrange
            ToyBoard.ToyBoard squareBoard = new ToyBoard.ToyBoard(5, 5);
            Position position = new Position(6, 6);

            // act
            var result = squareBoard.IsValidPosition(position);

            // assert
            Assert.IsFalse(result);
        }

    }
}
