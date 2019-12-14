using System;
using System.Collections.Generic;
using System.Text;

using ToyRobotSimulator.Services.Helper;

namespace ToyRobotSimulator.Services
{
    public class ToyRobotPlacementService: IToyRobotPlacementService
    {


       public ToyFacingDirectionEnum Direction { get; set; }
       public ToyPosition Position { get; set; }

        public void PlaceToy(ToyPosition position, ToyFacingDirectionEnum direction)
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
                case ToyFacingDirectionEnum.North:
                    ++newPosition.Y_Coordinate;
                    break;
                case ToyFacingDirectionEnum.East:
                   ++newPosition.X_Coordinate;
                    break;
                case ToyFacingDirectionEnum.South:
                   -- newPosition.Y_Coordinate;
                    break;
                case ToyFacingDirectionEnum.West:
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
            var directionsValues = (ToyFacingDirectionEnum[])Enum.GetValues(typeof(ToyFacingDirectionEnum));
           Direction= ((Direction + rotationPoint) < 0) ? directionsValues[directionsValues.Length - 1]:directionsValues[((int)(Direction + rotationPoint)) % directionsValues.Length];
            }
        }
    }

