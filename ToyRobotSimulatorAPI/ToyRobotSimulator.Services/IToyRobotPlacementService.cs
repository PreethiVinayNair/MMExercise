using System;
using System.Collections.Generic;
using System.Text;
using ToyRobotSimulator.Services.Helper;

namespace ToyRobotSimulator.Services
{
    public interface IToyRobotPlacementService
    { 
        //Function required to get the next available position for the toy
                ToyPosition GetNextAvailablePosition();
    
    }
}
