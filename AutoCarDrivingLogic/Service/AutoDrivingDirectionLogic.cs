using AutoCarDrivingLibrary;
using AutoCarDrivingLogic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AutoCarDrivingLogic.Service
{
    public class AutoDrivingDirectionLogic : IAutoDrivingDirectionLogic
    {
        private int angle { get; set; }

        public int X { get; set; }
        public int Y { get; set; }
        public Direction FacingDirection { get; set; }


        public AutoDrivingDirectionLogic()
        {
            //X = x;
            //Y = y;
            //FacingDirection = facingDirection;
        }
        public void Move(string commands, int maxWidth, int maxHeight)
        {
            switch (commands)
            {
                case "L":
                    RotateLeft();
                    break;
                case "R":
                    RotateRight();
                    break;
                case "F":
                    MoveForward(maxWidth, maxHeight, FacingDirection, X, Y);
                    break;
            }
        }

        public void RotateLeft()
        {
            // logic to rotate the car 90 degrees to the left
            angle -= 90;
            if (angle < 0)
            {
                angle = 360 + (angle % 360);

                Console.WriteLine("Angle after rotating right by 90 degrees to the left");
            }
        }

        public void RotateRight()
        {
            // logic to rotate the car 90 degrees to the right
            angle += 90;
            angle %= 360;
            Console.WriteLine("Angle after rotating right by 90 degrees to the right");
        }

        public void MoveForward(int Width, int Height, Direction CurrentDirection, int X, int Y)
        {
            // logic to move the car forward by 1 grid point
            // Check if the move is within the boundaries, otherwise ignore

            int newX = X;
            int newY = Y;

            newX++;

            switch (CurrentDirection)
            {
                case Direction.North:
                    newY++;
                    break;
                case Direction.South:
                    newY--;
                    break;
                case Direction.East:
                    newX++;
                    break;
                case Direction.West:
                    newX--;
                    break;
            }

            if (newX >= 0 && newX <= Width && newY >= 0 && newY <= Height)
            {
                X = newX;
                Y = newY;
                Console.WriteLine($"Moved forward to X: {X}, Y: {Y}, Direction: {CurrentDirection}");
            }
            else
            {
                Console.WriteLine("Cannot move forward, boundary reached.");
            }

        }

        //public void CheckResultMove()
        //{


        //}
    }
}
