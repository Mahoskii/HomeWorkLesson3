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
    }

    void MathIsMathing(int x)
    {
        x++;
        Debug.Log(x);
    }

    void IfExample(int x)
    {
        if(x >= 5)
        {
            Debug.Log($"I am a big number. My value is {x}");
        }
        else
        {
            Debug.Log($"I am not a big number. My value is {x}");
        }
    }

    void SwitchExample(int x)
    {
        switch (x)
        {
            case 1:
                Debug.Log("Did you know? An orange tabby cat called Stubbs was the mayor of Talkeetna, a small town in Alaska, for 20 years!");
                break;
            case 2:
                Debug.Log("Did you know? Isaac Newton invented the cat door!");
                break;
            case 3:
                Debug.Log("Did you know? In 1963 Felicette, also known as ‘Astrocat’ was the first and only cat to go to space!");
                break;
            default:
                Debug.Log("Sorry mate, your number is not on the list so no cat facts for you!");
                break;
        }
    }

}
