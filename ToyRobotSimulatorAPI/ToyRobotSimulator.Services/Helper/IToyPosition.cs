using System;
using System.Collections.Generic;
using System.Text;

namespace ToyRobotSimulator.Services.Helper
{
    //Interface defineing the Position Coordinates required
    public interface IToyPosition
    {
        int X_Coordinate { get; set; }
        int Y_Coordinate { get; set; }
    }
}
