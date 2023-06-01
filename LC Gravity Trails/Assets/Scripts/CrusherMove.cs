using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrusherMove : MonoBehaviour
{
    public float yForce;
    public float xForce;
    public float xDirection;
    public int leftMaximum;
    public int rightMaximum;
    public Teleport teleport;

    public Rigidbody2D enemyRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        enemyRigidBody = GetComponent<Rigidbody2D>();
        teleport = GameObject.FindGameObjectWithTag("Exit").GetComponent<Teleport>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if(transform.position.x <= leftMaximum)
        {
            xDirection = 1;
            enemyRigidBody.AddForce(Vector2.right * xForce);
        }
        if(transform.position.x >= rightMaximum)
        {
            xDirection = -1;
            enemyRigidBody.AddForce(Vector2.left * xForce);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Vector2 jumpForce = new Vector2(xForce * xDirection, yForce);
            enemyRigidBody.AddForce(jumpForce);
        }

        if (collision.gameObject.tag == "ThrowingObject")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            teleport.enemyCount -= 1;
        }
    }
}
