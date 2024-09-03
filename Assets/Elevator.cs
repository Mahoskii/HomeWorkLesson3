using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator
{
    public int CurrentFloor;
    public int ChosenFloor;
    public int PassengerNum;
    public bool Saturday;
    int MaxFloor = 10;
    int MinFloor = -2;
    int MaxCapacity = 480;
    

   public Elevator(int CurrentFloor, int ChosenFloor, int PassengerNum, bool Saturday)
    {
        this.CurrentFloor = CurrentFloor;
        this.ChosenFloor = ChosenFloor;
        this.PassengerNum = PassengerNum;
        this.Saturday = Saturday;
    }

    public void ElevatorFunction(int CurrentFloor, int ChosenFloor, int PassengerNum, bool Saturday, int MaxCapacity = 480, int MinFloor = -2, int MaxFloor = 10)
    {
        if(CurrentFloor > MaxFloor || CurrentFloor < MinFloor)
        {
            Debug.Log($"This building goes from floor {MinFloor} to floor {MaxFloor}");
            Debug.Log($"There is no button for floor {CurrentFloor}");
            return;
        }

        if (ChosenFloor > MaxFloor || ChosenFloor < MinFloor)
        {
            Debug.Log($"This building goes from floor {MinFloor} to floor {MaxFloor}");
            Debug.Log($"There is no button for floor {ChosenFloor}");
            return;
        }

        if (Capacity(PassengerNum, MaxCapacity))
        {
            Debug.Log("Max capacity has been surpressed. Please exit the elevator.");
            return;
        }

        if (Saturday)
        {
           IfSaturday(CurrentFloor, MinFloor, MaxFloor);

            return;
        }

        UpOrDown(CurrentFloor, ChosenFloor);

    }
    public void UpOrDown(int CurrentFloor, int ChosenFloor)
    {

        if(CurrentFloor > ChosenFloor)
        {
            GoDown(CurrentFloor, ChosenFloor);
            Debug.Log("You have arrived at your destination");
        }
        else if (CurrentFloor < ChosenFloor)
        {
            GoUp(CurrentFloor, ChosenFloor);
            Debug.Log("You have arrived at your destination");
        }
        else
        {
            Debug.Log("The Elevator is already here");
        }
    }

    public void GoUp(int CurrentFloor, int ChosenFloor)
    {
        for (int i = CurrentFloor; i <= ChosenFloor; i++, CurrentFloor++)
        {
            Debug.Log($"Floor: {CurrentFloor}");
        }
    }

    public void GoDown(int CurrentFloor, int ChosenFloor)
    {
        for (int i = CurrentFloor; i >= ChosenFloor; i--, CurrentFloor--)
        {
            Debug.Log($"Floor: {CurrentFloor}");
        }
    }

    public bool Capacity(int PassengerNum, int MaxCapacity)
    {
        int TotalWeight = 0;

        for (int i = 0; i < PassengerNum; i++)
        {
            int Weight = Random.Range(50, 90);
            TotalWeight += Weight;
        }
        if(TotalWeight >= MaxCapacity)
        {
            return true;
        }
        return false;
    }

    public void IfSaturday(int CurrentFloor, int MinFloor, int MaxFloor)
    {
        if(CurrentFloor == MinFloor || (CurrentFloor > MinFloor && CurrentFloor < MaxFloor))
        {
            GoUp(CurrentFloor, MaxFloor);
            GoDown(MaxFloor, MinFloor);
        } 
        else
        {
            GoDown(CurrentFloor, MinFloor);
            GoUp(MinFloor, MaxFloor);
        }
    }

}
