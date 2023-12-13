using AutoCarDrivingLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCarDrivingLogic.Interface
{
    public interface IAutoDrivingDirectionLogic
    {
        void RotateLeft();
        void RotateRight();
        void MoveForward(int Width, int Height, Direction direction, int X, int Y);

        void Move(string commands, int maxWidth, int maxHeight);
    }
}
