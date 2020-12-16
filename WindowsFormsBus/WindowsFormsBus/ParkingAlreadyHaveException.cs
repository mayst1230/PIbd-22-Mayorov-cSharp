using System;

namespace WindowsFormsBus
{
    internal class ParkingAlreadyHaveException : Exception
    {
        public ParkingAlreadyHaveException() : base("На парковке уже есть такой автобус")
        { }
    }
}
