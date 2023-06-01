using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatMovement : MonoBehaviour
{
    public float xDirectionRat;
    public int leftMaximumRat;
    public int rightMaximumRat;

    public Rigidbody2D ratRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        ratRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        ratRigidBody.AddForce(Vector2.right * xDirectionRat);

        if (transform.position.x <= leftMaximumRat)
        {
            xDirectionRat = 0.8f;
        }
        if (transform.position.x >= rightMaximumRat)
        {
            xDirectionRat = -0.8f;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ThrowingObject")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
   
}
