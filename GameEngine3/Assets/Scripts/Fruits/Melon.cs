using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melon : Fruit
{
    private CircleCollider2D contact;

    private void Update()
    {
        Reward();
    }
    public override void Reward()
    {
        Debug.Log("A Melon has Spawned! " + GameManager.Instance.currentScore.ToString() + "/5 From Winning!");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.currentScore += 1;
            Destroy(gameObject);

        }

    }
}
    
