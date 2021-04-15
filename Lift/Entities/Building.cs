using System.Linq;
using Lift.Enums;
using Lift;
using System;

namespace Lift.Entities
{
    public class Building
    {
        
        public Floor[] Floors { get; set; }

        public Lift Lift { get; set; }

        public Building(int liftCapacity, int[][] floorAndPeopleComposition)
        {
            Floors = floorAndPeopleComposition.Select((floorComposition, floorNumber) =>
            {
                var floor = new Floor(floorNumber, floorComposition);
                floor.ButtonPressedForCallingTheLift += this.LiftRequested;
                return floor;
            }).ToArray();

            Lift = new Lift(liftCapacity);
        }
     
        public void LiftRequested(Direction direction, int floorNumberRequestedOn)
        {

            Lift LiftIsMoving = new Lift();// making instance of lift to work with lift properties and methods.
            Floor WherePeopleWantToGo = new Floor();//making instance of floor to work with floor properties and methods.
            Person ForStatus = new Person();// making instance of person to work with person properties and methods.

            LiftIsMoving.CurrentFloor = floorNumberRequestedOn ;
            int NextFloorRequested = LiftIsMoving.CurrentFloor;//creating new int variable for getting the next floor lift should move
            while (LiftIsMoving.Capacity >= LiftIsMoving.PeopleInsideLift.Count  &&  ForStatus.WaitingStatus==WaitingStatus.Waiting)//for checking the status if its waiting then only we'll allow them to onboARD the lift 
            {
                int i = 0;
                 LiftIsMoving.PeopleInsideLift.Add(WherePeopleWantToGo.PeopleWaitingForLift[i]);//here i need some help regarding first time the lift is called (SHOULD I HAVE TO ONBOARD EVERYONE WAITING ON THE PARTICULAR FLOOR OR I HAVE TO GO DIRECTION WISE )
                 WherePeopleWantToGo.PeopleWaitingForLift.RemoveAt(i);//here i am removing people from the list of people waiting on the floor after updating the people inside lift list. 
                for (int j = 0; j < WherePeopleWantToGo.PeopleWaitingForLift.Count; j++)//here traversing all the people inside lift one by one
                {
                    LiftIsMoving.PeopleInsideLift.Add(WherePeopleWantToGo.PeopleWaitingForLift[j]);
                    WherePeopleWantToGo.PeopleWaitingForLift.RemoveAt(j);
                    ForStatus.WaitingStatus = WaitingStatus.BoardedLift;//changing status from waiting to onboarded

                    if (direction == Direction.GoingUp)//now if lift is going up we have to check for the highest floor on which lift is requested
                    {
                        foreach (Person FloorNumber in LiftIsMoving.PeopleInsideLift)
                        {
                            if (LiftIsMoving.CurrentFloor < Convert.ToInt32(FloorNumber))
                            {
                                NextFloorRequested = Convert.ToInt32(FloorNumber);//updating the created variable
                            }
                        }

                    }
                    else if (direction == Direction.GoingDown)//checking same if lift is going down
                    {
                        foreach (var FloorNumber in LiftIsMoving.PeopleInsideLift)
                        {
                            if (LiftIsMoving.CurrentFloor > Convert.ToInt32(FloorNumber))
                            {
                                NextFloorRequested = Convert.ToInt32(FloorNumber);
                            }
                        }

                    }
                    else if (LiftIsMoving.PeopleInsideLift.Count == 0)//checking if people inside lift is empty so return it to the ground floor and change direction of lift to stationary
                    {
                        NextFloorRequested = 0;
                        direction = Direction.Stationary;
                    }

                }

                }
            LiftIsMoving.CurrentFloor = NextFloorRequested;//updating the value of the current floor of the lift to next floor requested to make it go there.
            while (LiftIsMoving.Capacity >= LiftIsMoving.PeopleInsideLift.Count && ForStatus.WaitingStatus == WaitingStatus.BoardedLift)//this loop is to update the people list belong to particular floor and removing them from the people in the lift list along with changing there status from onboard to reached.
            {
                for(int i=0;i<LiftIsMoving.PeopleInsideLift.Count;i++)
                {
                    if(Convert.ToInt32(LiftIsMoving.PeopleInsideLift[i])== LiftIsMoving.CurrentFloor)
                    {
                        WherePeopleWantToGo.PeopleBelongToTheFloor.Add(LiftIsMoving.PeopleInsideLift[i]);
                        LiftIsMoving.PeopleInsideLift.RemoveAt(i);
                        ForStatus.WaitingStatus = WaitingStatus.Reached;
                    }
                }
            }
        }

    }
}
