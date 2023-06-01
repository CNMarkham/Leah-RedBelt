using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Throwable direction;
    public float speed;
    public bool isTriggered;
    

    // Start is called before the first frame update
    void Start()
    {
        direction = GameObject.FindGameObjectWithTag("Player").GetComponent<Throwable>();
        Invoke("DestroyThrowable", 2);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction.offset * Time.deltaTime * speed;
        
    }

    private void DestroyThrowable()
    {
        Destroy(gameObject);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Lever")
        {
            collision.gameObject.GetComponent<Lever>().flipSwitch();
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "LeverBlue")
        {
            collision.gameObject.GetComponent<LeverBlue>().flipSwitch();
            Destroy(gameObject);
        }
    }
}
