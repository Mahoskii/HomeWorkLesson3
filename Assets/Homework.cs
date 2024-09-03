using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int RandomInt = 3;

        MathIsMathing(RandomInt);

        IfExample(RandomInt);

        SwitchExample(RandomInt);

        Elevator FirstRun = new Elevator(0, 10, 2, false);
        Debug.Log("Elevator Function:");
        FirstRun.ElevatorFunction(FirstRun.CurrentFloor, FirstRun.ChosenFloor, FirstRun.PassengerNum, FirstRun.Saturday);

    }

    void MathIsMathing(int x)
    {
        x++;
        Debug.Log($"Math Is Mathing: {x}");
    }

    void IfExample(int x)
    {
        if(x >= 5)
        {
            Debug.Log($"If Example: I am a big number. My value is {x}");
        }
        else
        {
            Debug.Log($"If Example: I am not a big number. My value is {x}");
        }
    }

    void SwitchExample(int x)
    {
        switch (x)
        {
            case 1:
                Debug.Log("Switch Example: Did you know? An orange tabby cat called Stubbs was the mayor of Talkeetna, a small town in Alaska, for 20 years!");
                break;
            case 2:
                Debug.Log("Switch Example: Did you know? Isaac Newton invented the cat door!");
                break;
            case 3:
                Debug.Log("Switch Example: Did you know? In 1963 Felicette, also known as ‘Astrocat’ was the first and only cat to go to space!");
                break;
            default:
                Debug.Log("Switch Example: Sorry mate, your number is not on the list so no cat facts for you!");
                break;
        }
    }

}
