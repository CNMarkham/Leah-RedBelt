using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public bool isTriggered;

    public void flipSwitch()
    {
        if (isTriggered == false)
        {
            isTriggered = true;
        }
        else if (isTriggered)
        {
            isTriggered = false;
        }
    }
}
