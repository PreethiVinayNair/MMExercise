using System;
using System.Collections.Generic;
using Microsoft.Extensions.Primitives;

namespace ToyRobotSimulator.Services
{
    public interface IToyRobotSimulatorService
        
    {
        //Functionto get the arguments and run the function simulator
        string simulate(IDictionary<string, StringValues> toysimulatorArguments);
    }
}
