using System;
using System.Collections.Generic;
using System.Text;
using ToyRobotSimulator.Services.Helper;

namespace ToyRobotSimulator.Services
{
    public interface IToyBoardService
    {
        bool CheckPositionAvailability(ToyPosition position);
    }
}
