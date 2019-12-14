using System;
using System.Collections.Generic;
using System.Text;

using ToyRobotSimulator.Services.Helper;

namespace ToyRobotSimulator.Services
{
    public class ToyRobotPlacementService: IToyRobotPlacementService
    {


       public ToyFacingDirection Direction { get; set; }
       public ToyPosition Position { get; set; }

        public void PlaceToy(ToyPosition position, ToyFacingDirection direction)
        {
            this.Position = position;
            this.Direction = direction;

        }


        //Function to determine the next available position of the toy
        public ToyPosition GetNextAvailablePosition()
        {
            var newPosition = new ToyPosition(Position.X_Coordinate, Position.Y_Coordinate);
            switch (Direction)
            {
                case ToyFacingDirection.North:
                    newPosition.Y_Coordinate = newPosition.Y_Coordinate + 1;
                    break;
                case ToyFacingDirection.East:
                    newPosition.X_Coordinate = newPosition.X_Coordinate + 1;
                    break;
                case ToyFacingDirection.South:
                    newPosition.Y_Coordinate = newPosition.Y_Coordinate - 1;
                    break;
                case ToyFacingDirection.West:
                    newPosition.X_Coordinate = newPosition.X_Coordinate - 1;
                    break;
            }
            return newPosition;
        }

        public void Rotate(ToyCommandEnum toyCommand)
        {
            if (toyCommand == ToyCommandEnum.Left)
            {
            
            }
            else if (toyCommand == ToyCommandEnum.Right)
            {

            }


        }
    }
}
