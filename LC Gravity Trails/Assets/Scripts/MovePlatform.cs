using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    public int maxLeft;
    public int maxRight;
    public float platformDirection;
    public GameObject lever;
    public Lever leverScript;

    // Start is called before the first frame update
    void Start()
    {
        leverScript = lever.GetComponent<Lever>();
    }

    // Update is called once per frame
    void Update()
    {
        if (leverScript.isTriggered)
        {
            transform.position += Vector3.right * Time.deltaTime * platformDirection;

            if (transform.position.x <= maxLeft)
            {
                platformDirection = 1.5f;
            }
            if (transform.position.x >= maxRight)
            {
                platformDirection = -1.5f;
            }
        }
    }
}
