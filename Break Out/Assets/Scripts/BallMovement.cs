using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Rigidbody2D myRB;
    float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        myRB.velocity = Vector2.down * speed;
        Debug.Log("oi");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            myRB.velocity = new Vector2(myRB.velocity.x + collision.gameObject.GetComponent<Rigidbody2D>().velocity.x, myRB.velocity.y * -1);
        }
    }
}