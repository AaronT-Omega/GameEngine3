using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;
    public float jump;
    public LayerMask groundLayer;
    private Rigidbody2D rb2d;
    private BoxCollider2D bc;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        bc = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");


        rb2d.velocity = new Vector2(moveHorizontal * speed, rb2d.velocity.y);

        if (Input.GetButtonDown("Jump") && touchingLadder())
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, jump);
        }

      
    }


    bool touchingLadder()
    {
        return Physics2D.BoxCast(bc.bounds.center, bc.bounds.size, 0f, Vector2.down, 1f, groundLayer);
    }
}



