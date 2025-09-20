using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGuy : Enemy
{

    private BoxCollider2D contact;


    private void Update()
    {
        if (playerTarget != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, playerTarget.position, speed * Time.deltaTime);
        }

        Attack();


    }

    public override void Attack()
    {
        playerTarget = GameObject.FindGameObjectWithTag("Player").transform;
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.currentHP -= 1;
            Destroy(gameObject);

        }

    }
}
