using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatformBlue : MonoBehaviour
{
    public int maxUp;
    public int maxDown;
    public float platformDirection;
    public GameObject leverBlue;
    public LeverBlue leverScript;

    // Start is called before the first frame update
    void Start()
    {
        leverScript = leverBlue.GetComponent<LeverBlue>();
    }

    // Update is called once per frame
    void Update()
    {
        if (leverScript.isTriggeredBlue)
        {
            transform.position += Vector3.up * Time.deltaTime * platformDirection;

            if (transform.position.y >= maxUp)
            {
                platformDirection = -1.5f;
            }
            if (transform.position.y <= maxDown)
            {
                platformDirection = 1.5f;
            }
        }
    }
}
