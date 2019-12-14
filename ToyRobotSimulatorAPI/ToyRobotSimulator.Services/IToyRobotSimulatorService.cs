using System;
using System.Collections.Generic;
using Microsoft.Extensions.Primitives;

namespace ToyRobotSimulator.Services
{
    public interface IToyRobotSimulatorService
    {
        string simulate(IDictionary<string, StringValues> toysimulatorArguments);
    }
}
