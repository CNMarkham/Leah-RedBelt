using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverBlue : MonoBehaviour
{
    public bool isTriggeredBlue;

    public void flipSwitch()
    {
        if (isTriggeredBlue == false)
        {
            isTriggeredBlue = true;
        }
        else if (isTriggeredBlue)
        {
            isTriggeredBlue = false;
        }
    }
}
