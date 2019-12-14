using System;
using System.Collections.Generic;
using System.Text;
using ToyRobotSimulator.Services.Helper;

namespace ToyRobotSimulator.Services
{
    public interface IToyBoardService
    {
        //To check the availability of the poition
        bool CheckPositionAvailability(ToyPosition position);
    }
}
