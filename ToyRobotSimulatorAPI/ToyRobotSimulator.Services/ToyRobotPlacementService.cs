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
                    ++newPosition.Y_Coordinate;
                    break;
                case ToyFacingDirection.East:
                   ++newPosition.X_Coordinate;
                    break;
                case ToyFacingDirection.South:
                   -- newPosition.Y_Coordinate;
                    break;
                case ToyFacingDirection.West:
                    --newPosition.X_Coordinate;
                    break;
            }
            return newPosition;
        }

        public void Rotate(ToyCommandEnum toyCommand)
        {
            int rotationPoint;          
            if (toyCommand == ToyCommandEnum.Left)
            {
                RotateDirections(-1);
            }
            else if (toyCommand == ToyCommandEnum.Right)
            {
                RotateDirections(+1);
            }

        }

        private void RotateDirections(int rotationPoint)
        {
            var directionsValues = (ToyFacingDirection[])Enum.GetValues(typeof(ToyFacingDirection));
           Direction= ((Direction + rotationPoint) < 0) ? directionsValues[directionsValues.Length - 1]:directionsValues[((int)(Direction + rotationPoint)) % directionsValues.Length];
            }
        }
    }

