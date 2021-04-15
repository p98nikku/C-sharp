﻿using Lift.Enums;
using Lift.Exceptions;

namespace Lift.Entities
{
    public class Person
    {

        public event ButtonPressedForCallingTheLift ButtonPressed;

        public int CurrentFloor { get; set; }
        public int DestinationFloor { get; set; }

        public WaitingStatus WaitingStatus { get; set; }

        public Direction DirectionToGoIn
        {
            get
            {
                return CurrentFloor > DestinationFloor ? Direction.GoingDown : Direction.GoingUp;
            }
        }

        public Person(int currentFloor, int destinationFloor)
        {
            this.CurrentFloor = currentFloor;
            this.DestinationFloor = destinationFloor;
            this.WaitingStatus = WaitingStatus.Waiting;
        }
        public Person()
        {

        }

        public void PressButton()
        {
            this.ButtonPressed(this.DirectionToGoIn);

        }
    }
}