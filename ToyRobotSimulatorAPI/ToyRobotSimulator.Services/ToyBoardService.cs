using System;
using System.Collections.Generic;
using System.Text;
using ToyRobotSimulator.Services.Helper;

namespace ToyRobotSimulator.Services
{
    public class ToyBoardService :IToyBoardService
    {

        public int Rows_X { get; private set; }
        public int Columns_Y { get; private set; }

        public ToyBoardService(int rows, int columns)
        {
            this.Rows_X = rows;
            this.Columns_Y = columns;
        }

        // Function checks if position is available within the limits
        public bool CheckPositionAvailability(ToyPosition position)
        {
            return position.X_Coordinate < Columns_Y && position.X_Coordinate >= 0 &&
                   position.Y_Coordinate < Rows_X && position.Y_Coordinate >= 0;
        }
    }
}
