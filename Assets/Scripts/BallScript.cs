using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool inPlay;
    public Transform player;
    public float speed;
    public Transform explosion;
    public GameManager gm;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!inPlay)
            transform.position = player.position;

        if (Input.GetButtonDown("Jump") && !inPlay)
        {
            inPlay = true;
            rb.AddForce(Vector2.up * speed);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bottom")) { 
            Debug.Log("Ball hit the bottom of the screen");
            rb.velocity = Vector2.zero;
            inPlay = false;
            gm.UpdateLives(-1);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Brick")) {
            Transform newexp = Instantiate(explosion, collision.transform.position, collision.transform.rotation);
            Destroy(newexp.gameObject, 1f);
            gm.UpdateScore(collision.gameObject.GetComponent<Brick>().points);
            Destroy(collision.gameObject);
        }
    }

}
