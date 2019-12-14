using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using ToyRobotSimulator.Services.Helper;
using Microsoft.Extensions.Primitives;


namespace ToyRobotSimulator.Services
{
    /// <summary>
    /// This class is used to as a service class to simulate the behaviuor of a toy.
    /// </summary>
    public class ToyRobotSimulatorService : IToyRobotSimulatorService
    {

        ToyBoardService toyboard = new ToyBoardService(5, 5);
        ToyRobotPlacementService toyRobotPlacement = new ToyRobotPlacementService();

        public string simulate(IDictionary<string, StringValues> toysimulatorArguments)
        {
            string[] arguments = Convert.ToString(toysimulatorArguments["request"]).Split(';');//request=PLACE 0,0,NORTH;MOVE;MOVE;LEFT;REPORT
            return ExecSimulator(arguments);
        }

        private string ExecSimulator(string[] simulatorArguments)
        {
            foreach (string command in simulatorArguments)
            {
                ToyCommandEnum toyCommand;
                if (command.Contains("Place"))
                {
                    toyCommand = ToyCommandEnum.Place;
                }
                else
                {
                    toyCommand = (ToyCommandEnum)Enum.Parse(typeof(ToyCommandEnum), command);
                }

                switch (toyCommand)
                {
                    case ToyCommandEnum.Place:
                        string[] placeCommand = Regex.Replace(command, "PLACE ", "", RegexOptions.IgnoreCase).Split(',');
                        int toyPosition_XCoordinate = Convert.ToInt32(placeCommand[0]);
                        int toyPosition_YCoordainate = Convert.ToInt32(placeCommand[1]);
                        ToyPosition position = new ToyPosition(toyPosition_XCoordinate, toyPosition_YCoordainate);

                        string toyFacingDirection = placeCommand[2].ToString();
                        if (toyboard.CheckPositionAvailability(position))
                            toyRobotPlacement.PlaceToy(position, (ToyFacingDirection)Enum.Parse(typeof(ToyFacingDirection), toyFacingDirection));
                        break;
                    case ToyCommandEnum.Move:
                        var newPosition = toyRobotPlacement.GetNextAvailablePosition();
                        if (toyboard.CheckPositionAvailability(newPosition))
                            toyRobotPlacement.Position = newPosition;
                        break;
                    case ToyCommandEnum.Left:
                        toyRobotPlacement.Rotate(ToyCommandEnum.Left);
                        break;
                    case ToyCommandEnum.Right:
                        toyRobotPlacement.Rotate(ToyCommandEnum.Right);
                        break;
                    case ToyCommandEnum.Report:
                        string report = string.Format("Output: {0},{1},{2}", toyRobotPlacement.Position.X_Coordinate,
                  toyRobotPlacement.Position.Y_Coordinate, toyRobotPlacement.Direction.ToString().ToUpper());
                        return report;
                }
            }
            return string.Empty;
        }
    }
}
    
