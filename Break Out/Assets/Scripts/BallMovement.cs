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

        if (collision.gameObject.tag == "WallHorizontal")
        {
            myRB.velocity = new Vector2(myRB.velocity.x * -1, myRB.velocity.y);
        }

        if (collision.gameObject.tag == "WallVertical")
        {
            myRB.velocity = new Vector2(myRB.velocity.x, myRB.velocity.y * -1);
        }

        if (collision.gameObject.tag == "Block")
        {
            ScoreManager manager = FindObjectOfType<ScoreManager>();
            manager.ScorePoint();
            myRB.velocity = new Vector2(myRB.velocity.x, myRB.velocity.y * -1);
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Void")
        {
            ScoreManager manager = FindObjectOfType<ScoreManager>();
            manager.PlayAgain();
        }
    }
}
