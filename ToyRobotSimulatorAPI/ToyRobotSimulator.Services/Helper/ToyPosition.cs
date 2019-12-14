using System;

namespace ToyRobotSimulator.Services.Helper
{
    // This class will represent the Position for the toy

    public class ToyPosition
    {
        public int X_Coordinate { get; set; }
        public int Y_Coordinate { get; set; }

        public ToyPosition(int x_coordinate, int y_coordinate)
        {
            this.X_Coordinate = x_coordinate;
            this.Y_Coordinate = y_coordinate;
        }
    }
}